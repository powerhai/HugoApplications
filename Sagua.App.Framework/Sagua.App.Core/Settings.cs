using Sagua.App.Components.Settings;
using Xamarin.Forms;

namespace Sagua.App.Core
{
    public static class Settings
    {
        /// <summary>
        /// Simply setup your settings once when it is initialized.
        /// </summary>
        private static ISettings _mSettings;

        private static string _server = "192.168.1.107";

        public static ISettings AppSettings
        {
            get { return _mSettings ?? (_mSettings  = DependencyService.Get<ISettings>()); }
        }

        public const string DefaultUserNameKey = "DefaultUserName";

        public static string DefaultUserName
        {
            get { return AppSettings.GetValueOrDefault(DefaultUserNameKey, ""); }
            set
            {
                if (AppSettings.AddOrUpdateValue(DefaultUserNameKey, value))
                    AppSettings.Save();
            }
        }

        public const string DefaultUserPasswordKey = "DefaultUserPassword";

        public static string DefaultUserPassword
        {
            get { return AppSettings.GetValueOrDefault(DefaultUserPasswordKey, ""); }
            set
            {
                if (AppSettings.AddOrUpdateValue(DefaultUserPasswordKey, value))
                    AppSettings.Save();
            }
        }

        public static string Server
        {
            get { return _server; }
            set { _server = value; }
        }
    }
}