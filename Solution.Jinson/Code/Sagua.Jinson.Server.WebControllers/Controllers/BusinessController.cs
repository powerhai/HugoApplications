using System.Linq;
using System.Web.Mvc;
using Sagua.Jinson.Global.Models.PostModels;
using Sagua.Jinson.Global.Models.PostResults;
using Sagua.Jinson.Server.DB.Context;
using Sagua.Jinson.Server.DB.Models;

namespace Sagua.Jinson.Server.WebControllers.Controllers
{
    public class BusinessController : Controller
    {
        public JsonResult AddShop(AddShopPostModel model)
        {
            var result = new AddShopPostResult();
            using (var db = DbContextFactory.CreateDbContext())
            {
                var shop = new Shop() {Title = model.Title, ShopType = model.ShopType, Url = model.Url };
                db.Shops.Add(shop);
                db.SaveChanges();
                result.IsOk = true;
                result.ShopId = shop.ShopId;

            }
            return new JsonResult() { Data = result };
        }

        public JsonResult DeleteShop(DeleteShopPostModel model)
        {
            var result = new DeleteShopPostResult();
            using (var db = DbContextFactory.CreateDbContext())
            {
                result.IsOk = true;
                var shop = new Shop() {ShopId = model.ShopId };
                db.Shops.Attach(shop);
                db.Shops.Remove(shop);
                db.SaveChanges();

            }
            return new JsonResult() { Data = result };
        }
        public JsonResult GetShopsOfBusinessUser (GetShopsOfBusinessUserPostModel model)
        {
            var result = new GetShopsOfBusinessUserPostResults();
            using (var db = DbContextFactory.CreateDbContext())
            {
                result.IsOk = true;
                result.Shops = db.Shops.Select(a => new GetShopsOfBusinessUserPostResults.Shop() { Id = a.ShopId , ShopType = a.ShopType , Title = a.Title, Url = a.Url  }).ToList();
            }
            return new JsonResult() { Data = result };
        }

        public JsonResult UpdateShop(UpdateShopPostModel model)
        {
            var result = new UpdateShopPostResult();
            using (var db = DbContextFactory.CreateDbContext())
            {
                //var shop = new Shop() { ShopId = model.ShopId, ShopType = model.ShopType, Title = model.Title , Url = model.Url };
                //var entity = db.Entry<Shop>(shop);
                var shop = db.Shops.First(a => a.ShopId == model.ShopId);
                shop.Title = model.Title;
                shop.ShopType = model.ShopType;
                shop.Url = model.Url;
                db.SaveChanges();
                result.IsOk = true;
            }
            return new JsonResult() { Data = result };
        }
    }
}