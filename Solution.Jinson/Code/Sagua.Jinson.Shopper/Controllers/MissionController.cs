using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sagua.Jinson.Global.Domain;
using Sagua.Jinson.Global.Models.PostModels;
using Sagua.Jinson.Global.Models.PostResults;
using Sagua.Jinson.Shopper.Services;

namespace Sagua.Jinson.Shopper.Controllers
{
    public class MissionController
    {
        private readonly BusinessServerProvider mBusinessServerProvider;
        private readonly AuthorizationService mAuthorizationService;
        public MissionController(BusinessServerProvider businessServerProvider, AuthorizationService authorizationService)
        {
            mBusinessServerProvider = businessServerProvider;
            mAuthorizationService = authorizationService;
        }

        public async Task<PublishMissionPostResult> PublishMission(DateTime startDate,int startCount, int dayCount, decimal dayRise, string goodsId, decimal price)
        {
            var postModel = new PublishMissionPostModel() { StartDate = startDate, StartCount = startCount, DayCount = dayCount, DayRise = dayRise, GoodsId = goodsId, Price = price };
            var client = new RestSharp.RestClient(mBusinessServerProvider.GetServerUrl());
            var request = new RestSharp.RestRequest("/Mission/PublishMission");
            request.AddObject(postModel);
            var result = await client.ExecutePostTaskAsync<PublishMissionPostResult>(request);
            return result.Data;
        }

        public async Task<GetMissionsOfBusinessUserPostResults> GetMissionsOfBusinessUser ()
           
        {
            var postModel = new GetMissionsOfBusinessUserPostResults() {   };
            var client = new RestSharp.RestClient(mBusinessServerProvider.GetServerUrl());
            var request = new RestSharp.RestRequest("/Mission/GetMissionsOfBusinessUser");
            request.AddObject(postModel);
            var result = await client.ExecutePostTaskAsync<GetMissionsOfBusinessUserPostResults>(request);
            return result.Data;
        }

        public async Task<UpdateMissionPostResult> UpdateMission(long missionId,string goodsId, int planCount, ShopType shopType)
        {
            var postModel = new UpdateMissionPostModel() {  MissionId  = missionId, GoodsId = goodsId, PlanCount = planCount , ShopType = shopType };
            var client = new RestSharp.RestClient(mBusinessServerProvider.GetServerUrl());
            var request = new RestSharp.RestRequest("/Mission/UpdateMission");
            request.AddObject(postModel);
            var result = await client.ExecutePostTaskAsync<UpdateMissionPostResult>(request);
            return result.Data;
        }
        public async Task<DeleteMissionPostResult> DeleteMission(long missionId)
        {
            var postModel = new DeleteMissionPostModel() {MissionId = missionId  };
            var client = new RestSharp.RestClient(mBusinessServerProvider.GetServerUrl());
            var request = new RestSharp.RestRequest("/Mission/DeleteMission");
            request.AddObject(postModel);
            var result = await client.ExecutePostTaskAsync<DeleteMissionPostResult>(request);
            return result.Data;
        }
    }
}
