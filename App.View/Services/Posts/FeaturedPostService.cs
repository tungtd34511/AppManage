using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Posts
{
    public class FeaturedPostService : IFeaturedPostService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public FeaturedPostService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<FeaturedPost>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "FeaturedPosts");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<FeaturedPost>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
