using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Posts
{
    public class PostCommentStatusService : IPostCommentStatusService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public PostCommentStatusService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<PostCommentStatus>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "PostCommentStatus");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<PostCommentStatus>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
