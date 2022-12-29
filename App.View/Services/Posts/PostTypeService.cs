using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Posts
{
    public class PostTypeService : IPostTypeService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public PostTypeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<PostType>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "PostTypes");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<PostType>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
