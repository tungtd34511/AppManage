using App.Data.Models;
using App.View.Ultilities.Contants;
using Newtonsoft.Json;

namespace App.View.Services.Comments
{
    public class AuthorService : IAuthorService
    {
        private readonly string _baseAdress = SystemContant.AppSettings.BaseAddress;
        private readonly HttpClient _httpClient;
        public AuthorService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Author>> GetAll()
        {
            var response = await _httpClient.GetAsync(_baseAdress + "Authors");
            var stringResponse = await response.Content.ReadAsStringAsync();
            var objects = JsonConvert.DeserializeObject<List<Author>>(stringResponse);
            if (objects != null)
            {
                return objects;
            }
            return new();
        }
    }
}
