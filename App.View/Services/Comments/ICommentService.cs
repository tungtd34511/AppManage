using App.Data.Models;

namespace App.View.Services.Comments
{
    public interface ICommentService
    {
        Task<List<Comment>> GetAll();
    }
}
