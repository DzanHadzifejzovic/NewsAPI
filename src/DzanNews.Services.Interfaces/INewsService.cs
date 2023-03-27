

using DzanNews.DataModel;
using DzanNews.DataModel.News;

namespace DzanNews.Services.Interfaces
{
    public interface INewsService
    {
        List<GetNewsResponseSP> GetNews(GetNewsRequestSP request);
        public string EditNews();
        public string InsertNews();

    }
}