using System.Linq;
using System.Web.Mvc;
using Sagua.Jinson.Global.Domain;
using Sagua.Jinson.Global.Models.PostModels;
using Sagua.Jinson.Global.Models.PostResults;
using Sagua.Jinson.Server.DB.Context;
using Sagua.Jinson.Server.DB.Models;

namespace Sagua.Jinson.Server.WebControllers.Controllers
{
    public class AccountController : Controller
    {

        public JsonResult UpdatePassword(UpdatePasswordPostModel model)
        {
            var result = new UpdatePasswordPostResult();
            using (var db = DbContextFactory.CreateDbContext())
            {
                var acc = db.Accounts.First(a => a.UserName == model.UserName);
                if(acc.Password == model.OldPassword)
                {
                    result.IsOk = true;
                    acc.Password = model.NewPassword;
                    db.SaveChanges();
                } else
                {
                    result.ErrorMessage = "旧密码不对";
                }

            }
            return new JsonResult() { Data = result };
        }

        public JsonResult RegisterBusinessUser (RegisterBusinessUserPostModel model)
        {
            var result =new RegisterBusinessUserPostResults();
            using(var db = DbContextFactory.CreateDbContext())
            {
                if(db.Accounts.Any(a => a.UserName == model.UserName))
                {
                    result.ErrorMessage = "已存在相同用户名，请更换后再试";
                } else
                {
                    db.Accounts.Add(new Account()
                    {
                        UserName = model.UserName,
                        Mail = model.Mail,
                        Password = model.Password,
                        QQ = model.QQ,
                        Tel = model.Tel,
                        UserType = UserType.Business
                    });
                    db.SaveChanges();
                    result.IsOk = true;
                }
            }
            return new JsonResult(){ Data = result};
        }

        [HttpPost]
        public JsonResult Login(LoginPostModel model)
        {
            var result = new LoginPostResults();
            using(var db = DbContextFactory.CreateDbContext())
            {
                if(db.Accounts.Any(a=>a.UserName == model.UserName && a.Password == model.Password ))
                {
                    result.IsOk = true;
                }else
                {
                    result.ErrorMessage = "帐号或密码不对";
                }
            }
            return new JsonResult(){ Data = result };
        }
    }
}