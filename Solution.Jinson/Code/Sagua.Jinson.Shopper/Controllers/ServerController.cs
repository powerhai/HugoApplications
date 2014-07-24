using System.Threading.Tasks;
using Sagua.Jinson.Global.Models.PostModels;
using Sagua.Jinson.Global.Models.PostResults;
using Sagua.Jinson.Shopper.Services;

namespace Sagua.Jinson.Shopper.Controllers
{
    public class ServerController
    {
        private readonly BusinessServerProvider mBusinessServerProvider;
        private readonly AuthorizationService mAuthorizationService;
        public ServerController (BusinessServerProvider businessServerProvider,
            AuthorizationService authorizationService)
        {
            mBusinessServerProvider = businessServerProvider;
            mAuthorizationService = authorizationService;
        }
       
        public async Task<GetServersPostResult> GetServers()
        {
            var postModel = new GetServersPostModel() { };
            var client = new RestSharp.RestClient(mBusinessServerProvider.GetServerUrl());
            var request = new RestSharp.RestRequest("/Server/GetServers");
            request.AddObject(postModel);
            var result = await client.ExecutePostTaskAsync<GetServersPostResult>(request);
            return result.Data;
        }
        public async Task<AddServerPostResult> AddServer(string url, bool isOpenning)
        {
            var postModel = new AddServerPostModel() { Url = url , IsOpenning = isOpenning };
            var client = new RestSharp.RestClient(mBusinessServerProvider.GetServerUrl());
            var request = new RestSharp.RestRequest("/Server/AddServer");
            request.AddObject(postModel);
            var result = await client.ExecutePostTaskAsync<AddServerPostResult>(request);
            return result.Data;
        }

        public async Task<DelServerPostResult> DelServer(long id)
        {
            var postModel = new DelServerPostModel() {Id = id };
            var client = new RestSharp.RestClient(mBusinessServerProvider.GetServerUrl());
            var request = new RestSharp.RestRequest("/Server/DelServer");
            request.AddObject(postModel);
            var result = await client.ExecutePostTaskAsync<DelServerPostResult>(request);
            return result.Data;
        }
    }
}