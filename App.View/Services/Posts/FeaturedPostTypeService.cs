﻿using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Posts
{
    public class FeaturedPostTypeService : IFeaturedPostTypeService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public FeaturedPostTypeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<FeaturedPostType>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "FeaturedPostTypes");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<FeaturedPostType>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
