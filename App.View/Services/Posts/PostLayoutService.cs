using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Posts
{
    public class PostLayoutService : IPostLayoutService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public PostLayoutService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<PostLayout>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "PostLayouts");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<PostLayout>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
