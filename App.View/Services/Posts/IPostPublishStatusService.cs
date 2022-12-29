using App.Data.Models;

namespace App.View.Services.Posts
{
    public interface IPostPublishStatusService
    {
        Task<List<PostPublishStatus>> GetAll();
    }
}
