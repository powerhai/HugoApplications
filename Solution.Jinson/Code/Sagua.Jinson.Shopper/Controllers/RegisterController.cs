using System.Threading.Tasks;
using Sagua.Jinson.Global.Models.PostModels;
using Sagua.Jinson.Global.Models.PostResults;
using Sagua.Jinson.Shopper.Services;

namespace Sagua.Jinson.Shopper.Controllers
{
    public class RegisterController
    {
        private readonly BusinessServerProvider mBusinessServerProvider;
        private readonly AuthorizationService mAuthorizationService;
        public RegisterController (BusinessServerProvider businessServerProvider, AuthorizationService authorizationService)
        {
            mBusinessServerProvider = businessServerProvider;
            mAuthorizationService = authorizationService;
        }

        public async Task<RegisterBusinessUserPostResults> Register (string userName,
            string password,
            string qq,
            string tel,
            string mail)
        {
            var postModel = new RegisterBusinessUserPostModel() { UserName = userName, Password = password , QQ = qq, Tel = tel, Mail = mail };
            var client = new RestSharp.RestClient(mBusinessServerProvider.GetServerUrl());
            var request = new RestSharp.RestRequest("/Account/RegisterBusinessUser");
            request.AddObject(postModel);
            var result = await client.ExecutePostTaskAsync<RegisterBusinessUserPostResults>(request);
            if (result.Data.IsOk)
            {
                mAuthorizationService.UserName = userName;
                mAuthorizationService.IsLogined = true;
            }
            return result.Data;
        }
    }
}