using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sagua.Jinson.Global.Models.PostModels;
using Sagua.Jinson.Global.Models.PostResults;
using Sagua.Jinson.Shopper.Services;

namespace Sagua.Jinson.Shopper.Controllers
{
    public class OrderController
    {
        private readonly BusinessServerProvider mBusinessServerProvider;
        private readonly AuthorizationService mAuthorizationService;
        public OrderController(BusinessServerProvider businessServerProvider, AuthorizationService authorizationService)
        {
            mBusinessServerProvider = businessServerProvider;
            mAuthorizationService = authorizationService;
        }
        public async Task<GetOrdersOfBusinessUserByPagePostResult> GetOrdersOfBusinessUserByPage(long lastId)
        {
            var postModel = new GetOrdersOfBusinessUserByPagePostModel() { LastID = lastId };
            var client = new RestSharp.RestClient(mBusinessServerProvider.GetServerUrl());
            var request = new RestSharp.RestRequest("/Order/GetOrdersOfBusinessUserByPage");
            request.AddObject(postModel);
            var result = await client.ExecutePostTaskAsync<GetOrdersOfBusinessUserByPagePostResult>(request);
            return result.Data;
        }
    }
}
