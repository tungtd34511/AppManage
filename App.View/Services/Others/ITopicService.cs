using App.Data.Models;

namespace App.View.Services.Others
{
    public interface ITopicService
    {
        Task<List<Topic>> GetAll();
    }
}
