using App.Data.Models;

namespace App.View.Services.Posts
{
    public interface IFeaturedPostService
    {
        Task<List<FeaturedPost>> GetAll();
    }
}
