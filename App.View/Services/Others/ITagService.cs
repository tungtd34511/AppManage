using App.Data.Models;

namespace App.View.Services.Others
{
    public interface ITagService
    {
        Task<List<Tag>> GetAll();
    }
}
