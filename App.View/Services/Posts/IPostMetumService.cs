using App.Data.Models;

namespace App.View.Services.Posts
{
    public interface IPostMetumService
    {
        Task<List<PostMetum>> GetAll();
    }
}
