using App.Data.Models;

namespace App.View.Services.Posts
{
    public interface IPostTypeService
    {
        Task<List<PostType>> GetAll();
    }
}
