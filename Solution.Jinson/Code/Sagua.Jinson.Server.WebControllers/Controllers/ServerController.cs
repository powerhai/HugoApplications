using System.Linq;
using System.Web.Mvc;
using Sagua.Jinson.Global.Models.PostModels;
using Sagua.Jinson.Global.Models.PostResults;
using Sagua.Jinson.Server.DB.Context;

namespace Sagua.Jinson.Server.WebControllers.Controllers
{
    public class ServerController : Controller
    {
        public JsonResult DelServer(DelServerPostModel model)
        {
            var result = new DelServerPostResult();
            using (var db = DbContextFactory.CreateDbContext())
            {
                var server = db.Servers.First(a => a.ServerId == model.Id);
                db.Servers.Remove(server);
                db.SaveChanges();
                result.IsOk = true;

            }
            return new JsonResult() { Data = result };
        }
        public JsonResult AddServer(AddServerPostModel model)
        {
            var result = new AddServerPostResult();
            using (var db = DbContextFactory.CreateDbContext())
            {
                var server = new DB.Models.Server() {IsOpenning = model.IsOpenning, Url = model.Url };
                db.Servers.Add(server);
                db.SaveChanges();
                result.IsOk = true;
                result.Id = server.ServerId;
                result.IsOpenning = server.IsOpenning;
                result.Url = server.Url;
            }
            return new JsonResult() { Data = result };
        }

        public JsonResult GetServers(GetServersPostModel model)
        {
            var result = new GetServersPostResult();
            using (var db = DbContextFactory.CreateDbContext())
            {
                result.Servers = db.Servers.Select(a => new GetServersPostResult.Server()
                {
                    Url = a.Url,
                    IsOpenning = a.IsOpenning ,
                    Id = a.ServerId 
                }).ToList();
                result.IsOk = true;

            }
            return new JsonResult() { Data = result };
        }
    }
}