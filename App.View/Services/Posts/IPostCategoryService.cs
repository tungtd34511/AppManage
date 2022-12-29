using App.Data.Models;

namespace App.View.Services.Posts
{
    public interface IPostCategoryService
    {
        Task<List<PostCategory>> GetAll();
    }
}
