using System.Web.Mvc;
using Sagua.Jinson.Server.DB.Context;
using Sagua.Jinson.Server.DB.Models;

namespace Sagua.Jinson.Server.WebControllers.Controllers
{
    public class HomeController : Controller
	{
		public ActionResult Index ()
		{
		    var db = DbContextFactory.CreateDbContext();
		    db.Users.Add(new User() { Name = "fuckwwwyou" , Tel = "88555"});
		    db.SaveChanges();
			return new ContentResult(){Content = "haiahiahia"};
		}
	 
//
//        [HttpPost]
//        public ActionResult PostImage(HttpPostedFileBase image, LoginPostModel postModel)
//        {
//            var memio = new System.IO.MemoryStream();
//            image.InputStream.CopyTo(memio);
//            var bytes = memio.ToArray();
//            var result = new LoginResult() { UserName = postModel.UserName　 + bytes.Length.ToString()  };
//            return new JsonResult() { Data = result };
//        }
 
		  
	}
}

