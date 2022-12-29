using App.Data.Models;

namespace App.View.Services.Posts
{
    public interface IFeaturedPostTypeService
    {
        Task<List<FeaturedPostType>> GetAll();
    }
}
