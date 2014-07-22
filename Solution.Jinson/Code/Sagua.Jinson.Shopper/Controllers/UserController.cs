using System.Threading.Tasks;
using Sagua.Jinson.Global.Models.PostModels;
using Sagua.Jinson.Global.Models.PostResults;
using Sagua.Jinson.Shopper.Services;

namespace Sagua.Jinson.Shopper.Controllers
{
    public class UserController
    {
        private readonly BusinessServerProvider mBusinessServerProvider;
        private readonly AuthorizationService mAuthorizationService;
        public UserController (BusinessServerProvider businessServerProvider,
            AuthorizationService authorizationService)
        {
            mBusinessServerProvider = businessServerProvider;
            mAuthorizationService = authorizationService;
        }

        public async Task<UpdatePasswordPostResult> UpdatePassword(string userName,string oldPassword,string newPassword)
        {
            var postModel = new UpdatePasswordPostModel() { UserName = userName, OldPassword = oldPassword, NewPassword = newPassword  };
            var client = new RestSharp.RestClient(mBusinessServerProvider.GetServerUrl());
            var request = new RestSharp.RestRequest("/Account/UpdatePassword");
            request.AddObject(postModel);
            var result = await client.ExecutePostTaskAsync<UpdatePasswordPostResult>(request);
            return result.Data;
        }
    }
}