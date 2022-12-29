using App.Data.Models;

namespace App.View.Services.Comments
{
    public interface ICommentStatusService
    {
        Task<List<CommentStatus>> GetAll();
    }
}
