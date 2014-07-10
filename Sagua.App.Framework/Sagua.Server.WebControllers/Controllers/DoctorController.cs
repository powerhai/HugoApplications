using System.Web;
using System.Web.Mvc;
using Sagua.Global.Models.RestPostModels;
using Sagua.Global.Models.RestResults;

namespace Sagua.Server.WebControllers.Controllers
{
    public class DoctorController : Controller
    {
        public JsonResult GetDoctorById(GetDoctorByIdPostModel model)
        {
            return new JsonResult(){ Data = new GetDoctorByIdResults(){Id = 3, Name = "黄药师"} };
        }

        public JsonResult SetDoctorPhoto(HttpPostedFileBase image , SetDoctorPhotoPostModel model)
        {
            
            return new JsonResult() {  Data = new SetDoctorPhotoResults(){ Info = image.FileName + " - " + image.ContentLength.ToString( ) + " " + model.Id.ToString()} };
        }
    }
}