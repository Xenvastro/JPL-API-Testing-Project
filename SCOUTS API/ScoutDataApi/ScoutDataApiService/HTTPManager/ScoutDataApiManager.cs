﻿using JPL_API_Library;
using RestSharp;

namespace ScoutDataApi.ScoutDataApiService.HTTPManager
{
    public class ScoutAPIManager
    {
        private readonly IRestClient client;

        public ScoutAPIManager()
        {
            client = new RestClient(ConfigReader.BaseUrl);
        }

        public string GetScoutData()
        {
            var request = new RestRequest("scout.api");
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}