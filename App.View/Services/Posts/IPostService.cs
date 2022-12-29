using App.Data.Models;

namespace App.View.Services.Posts
{
    public interface IPostService
    {
        Task<List<Post>> GetAll();
    }
}
