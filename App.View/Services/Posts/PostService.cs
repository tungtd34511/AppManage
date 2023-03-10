using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Posts
{
    public class PostService : IPostService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public PostService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Post>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "Posts");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<Post>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
