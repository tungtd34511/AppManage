using App.Data.Models;

namespace App.View.Services.Posts
{
    public interface IFavoritePostService
    {
        Task<List<FavouritePost>> GetAll();
    }
}
