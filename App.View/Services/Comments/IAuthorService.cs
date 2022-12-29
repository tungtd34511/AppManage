using App.Data.Models;

namespace App.View.Services.Comments
{
    public interface IAuthorService
    {
        Task<List<Author>> GetAll();
    }
}
