using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Posts
{
    public class PostTagService : IPostTagService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public PostTagService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<PostTag>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "PostTags");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<PostTag>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
