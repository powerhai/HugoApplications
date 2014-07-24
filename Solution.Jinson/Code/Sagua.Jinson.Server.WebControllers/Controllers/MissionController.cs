using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Sagua.Jinson.Global.Domain;
using Sagua.Jinson.Global.Models.PostModels;
using Sagua.Jinson.Global.Models.PostResults;
using Sagua.Jinson.Server.DB.Context;
using Sagua.Jinson.Server.DB.Models;

namespace Sagua.Jinson.Server.WebControllers.Controllers
{
    public class MissionController : Controller
    {

        public JsonResult PublishMission(PublishMissionPostModel model)
        {
            var result = new PublishMissionPostResult();
            using (var db = DbContextFactory.CreateDbContext())
            {
                var plancount = model.StartCount;
                var upTasks = new List<Mission>();
                for(var i = 0; i < model.DayCount; i++)
                {
                    var date = model.StartDate.AddDays(i).Date ;
                    plancount = (int)(plancount * ((decimal)100+ model.DayRise)/100);
                    if(date.Date < DateTime.Now.Date)
                    {
                        break;
                    }
                    if(db.Missions.Any(a => a.GoodsId == model.GoodsId && a.Date == date && a.MissionStatus == BuyTaskStatus.Normal))
                    {
                        var task = db.Missions.First(a => a.GoodsId == model.GoodsId && a.Date == date && a.MissionStatus == BuyTaskStatus.Normal);
                        task.PlanCount = plancount;
                        upTasks.Add(task);

                    } else
                    {
                        var task = new Mission()
                        {
                            Date = date,
                            GoodsId = model.GoodsId,
                            MissionStatus = BuyTaskStatus.Normal,
                            PlanCount = plancount,
                            ShopType = ShopType.Taobao
                        };
                        db.Missions.Add(task);
                        upTasks.Add(task);

                    }
                    
                }
                db.SaveChanges();
                foreach(var item in upTasks)
                {
                    result.Missions.Add(new PublishMissionPostResult.Mission()
                    {
                        Date = item.Date,
                        GoodsId = item.GoodsId,
                        Id = item.MissionId,
                        PlanCount = item.PlanCount,
                        ShopType = item.ShopType,
                        TaskStatus = item.MissionStatus
                    });
                }
                result.IsOk = true;

            }
            return new JsonResult() { Data = result };
        }

        public JsonResult DeleteMission(DeleteMissionPostModel model)
        {
            var result = new DeleteMissionPostResult();
            using (var db = DbContextFactory.CreateDbContext())
            {
                var mission = new Mission() {MissionId = model.MissionId};
                db.Missions.Attach(mission);
                db.Missions.Remove(mission);
                db.SaveChanges();
                result.IsOk = true;

            }
            return new JsonResult() { Data = result };
        }

        public JsonResult UpdateMission(UpdateMissionPostModel model)
        {
            var result = new UpdateMissionPostResult();
            using (var db = DbContextFactory.CreateDbContext())
            {
                var mission = db.Missions.First(a => a.MissionId == model.MissionId);
                mission.GoodsId = model.GoodsId;
                mission.PlanCount = model.PlanCount;
                mission.ShopType = model.ShopType;
                db.SaveChanges();
                result.IsOk = true;

            }
            return new JsonResult() { Data = result };
        }

        public JsonResult GetMissionsOfBusinessUser (GetMissionsOfBusinessUserPostModel model)
        {
            var result = new GetMissionsOfBusinessUserPostResults();
            using (var db = DbContextFactory.CreateDbContext())
            {
                result.IsOk = true;
                result.Missions =
                    db.Missions.Select(a => new GetMissionsOfBusinessUserPostResults.Mission()
                    {
                       Date = a.Date,  Id = a.MissionId, GoodsId = a.GoodsId, MissionStatus = a.MissionStatus, PlanCount = a.PlanCount, RealCount = a.RealCount, ShopType = a.ShopType   
                    }).ToList();


            }
            return new JsonResult() { Data = result };
        }
    }
}