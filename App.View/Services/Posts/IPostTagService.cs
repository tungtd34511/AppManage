using App.Data.Models;

namespace App.View.Services.Posts
{
    public interface IPostTagService
    {
        Task<List<PostTag>> GetAll();
    }
}
