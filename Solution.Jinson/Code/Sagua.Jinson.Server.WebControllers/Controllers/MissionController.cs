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
                        Id = a.MissionId, GoodsId = a.GoodsId, MissionStatus = a.MissionStatus, PlanCount = a.PlanCount, RealCount = a.RealCount, ShopType = a.ShopType   
                    }).ToList();


            }
            return new JsonResult() { Data = result };
        }
    }
}