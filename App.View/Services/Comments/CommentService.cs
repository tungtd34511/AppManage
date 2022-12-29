using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Comments
{
    public class CommentService : ICommentService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public CommentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Comment>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "Comments");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<Comment>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
