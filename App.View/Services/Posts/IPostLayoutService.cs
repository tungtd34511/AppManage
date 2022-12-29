using App.Data.Models;

namespace App.View.Services.Posts
{
    public interface IPostLayoutService
    {
        Task<List<PostLayout>> GetAll();
    }
}
