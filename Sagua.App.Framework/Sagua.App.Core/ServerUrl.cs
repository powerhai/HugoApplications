namespace Sagua.App.Core
{
    public class ServerUrl
    {
        public const string HttpString = "http://{0}/{1}/{2}";
        public static string GetDoctorByIdUrl
        {
            get { return string.Format(HttpString, Settings.Server, "Doctor", "GetDoctorById"); }
        }

        public static string SetDoctorPhotoPostModel
        {
            get { return string.Format(HttpString, Settings.Server, "Doctor", "SetDoctorPhoto"); }
        }


    }
}
