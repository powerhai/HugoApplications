using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Sagua.Jinson.Global.Models.PostModels;
using Sagua.Jinson.Global.Models.PostResults; 
using Sagua.Jinson.Shopper.Services;

namespace Sagua.Jinson.Shopper.Controllers
{
    public class LoginController
    {
        private readonly BusinessServerProvider mBusinessServerProvider;
        private readonly AuthorizationService mAuthorizationService;
        public LoginController (BusinessServerProvider businessServerProvider , AuthorizationService authorizationService)
        {
            mBusinessServerProvider = businessServerProvider;
            mAuthorizationService = authorizationService;
        }
        public async Task<LoginPostResults> Login(string userName, string password)
        {
            var postModel = new LoginPostModel() {UserName = userName, Password = password};
            var client = new RestSharp.RestClient(mBusinessServerProvider.GetServerUrl());
            var request = new RestSharp.RestRequest("/Account/Login");
            request.AddObject(postModel);
            var result = await  client.ExecutePostTaskAsync<LoginPostResults>(request);
            if(result.Data.IsOk)
            {
                mAuthorizationService.UserName = userName;
                mAuthorizationService.IsLogined = true;
            }
            return result.Data;
        }
    }
}
