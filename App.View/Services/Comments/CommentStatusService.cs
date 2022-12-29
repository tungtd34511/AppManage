using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Comments
{
    public class CommentStatusService : ICommentStatusService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public CommentStatusService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<CommentStatus>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "CommentStatus");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<CommentStatus>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
