using System.Threading.Tasks;
using Sagua.Jinson.Global.Domain;
using Sagua.Jinson.Global.Models.PostModels;
using Sagua.Jinson.Global.Models.PostResults;
using Sagua.Jinson.Shopper.Services;

namespace Sagua.Jinson.Shopper.Controllers
{
    public class ShopController
    {
        private readonly BusinessServerProvider mBusinessServerProvider;
        private readonly AuthorizationService mAuthorizationService;
        public ShopController (BusinessServerProvider businessServerProvider, AuthorizationService authorizationService)
        {
            mBusinessServerProvider = businessServerProvider;
            mAuthorizationService = authorizationService;
        }

        public async Task<GetShopsOfBusinessUserPostResults> GetShopsOfBusinessUser ()
        {
            var postModel = new GetShopsOfBusinessUserPostModel();
            var client = new RestSharp.RestClient(mBusinessServerProvider.GetServerUrl());
            var request = new RestSharp.RestRequest("/Business/GetShopsOfBusinessUser");
            request.AddObject(postModel);
            var result = await client.ExecutePostTaskAsync<GetShopsOfBusinessUserPostResults>(request);
            if (result.Data.IsOk)
            {
                mAuthorizationService.IsLogined = true;
            }
            return result.Data;
        }

        public async Task<AddShopPostResult> AddShop(string title,string url, ShopType shopType)
        {
            var postModel = new AddShopPostModel() { Title = title, Url = url, ShopType = shopType};
            var client = new RestSharp.RestClient(mBusinessServerProvider.GetServerUrl());
            var request = new RestSharp.RestRequest("/Business/AddShop");
            request.AddObject(postModel);
            var result = await client.ExecutePostTaskAsync<AddShopPostResult>(request);
            return result.Data;
        }

        public async Task<UpdateShopPostResult> UpdateShop(long shopId,string title,string url,ShopType shopType)
        {
            var postModel = new UpdateShopPostModel() { ShopId = shopId, Title = title,Url = url, ShopType = shopType };
            var client = new RestSharp.RestClient(mBusinessServerProvider.GetServerUrl());
            var request = new RestSharp.RestRequest("/Business/UpdateShop");
            request.AddObject(postModel);
            var result = await client.ExecutePostTaskAsync<UpdateShopPostResult>(request);
            return result.Data;
        }

        public async Task<DeleteShopPostResult> DeleteShop(long shopId)
        {
            var postModel = new DeleteShopPostModel() { ShopId = shopId};
            var client = new RestSharp.RestClient(mBusinessServerProvider.GetServerUrl());
            var request = new RestSharp.RestRequest("/Business/DeleteShop");
            request.AddObject(postModel);
            var result = await client.ExecutePostTaskAsync<DeleteShopPostResult>(request);
            return result.Data;
        }
    }
}