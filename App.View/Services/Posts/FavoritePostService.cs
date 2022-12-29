using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Posts
{
    public class FavoritePostService : IFavoritePostService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public FavoritePostService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<FavouritePost>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "FavouritePosts");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<FavouritePost>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
