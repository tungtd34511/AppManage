using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Posts
{
    public class PostMetumService : IPostMetumService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public PostMetumService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<PostMetum>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "PostMetums");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<PostMetum>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
