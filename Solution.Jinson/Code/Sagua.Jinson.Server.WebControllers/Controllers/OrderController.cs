using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;
using Sagua.Jinson.Global.Models.PostModels;
using Sagua.Jinson.Global.Models.PostResults;
using Sagua.Jinson.Server.DB.Context;

namespace Sagua.Jinson.Server.WebControllers.Controllers
{
    public class OrderController: Controller
    {
        public JsonResult GetOrdersOfBusinessUserByPage(GetOrdersOfBusinessUserByPagePostModel model)
        {
            var pageSize = 20;
            var result = new GetOrdersOfBusinessUserByPagePostResult();
            Thread.Sleep(2000);
            using (var db = DbContextFactory.CreateDbContext())
            {
                result.IsOk = true;
                var items = model.LastID == 0? db.Orders.Take(pageSize) : db.Orders.Where(a=>a.OrderId < model.LastID ).Take(pageSize);
                foreach(var item in items)
                {
                    result.Orders.Add(new GetOrdersOfBusinessUserByPagePostResult.Order()
                    {
                        Buyer = item.Buyer,
                        BuyTime = item.BuyTime,
                        BuyerAccount = item.BuyerAccount,
                        OrderId = item.OrderId,
                        PayTime = item.PayTime,
                        Price = item.Price
                    });
                }
                result.IsOver = result.Orders.Count < pageSize;
            }
            return new JsonResult() { Data = result };
        }
    }
}
