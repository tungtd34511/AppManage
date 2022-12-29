using App.Data.Models;

namespace App.View.Services.Posts
{
    public interface IPostTopicService
    {
        Task<List<PostTopic>> GetAll();
    }
}
