using App.Data.Models;

namespace App.View.Services.Posts
{
    public interface IPostCommentStatusService
    {
        Task<List<PostCommentStatus>> GetAll();
    }
}
