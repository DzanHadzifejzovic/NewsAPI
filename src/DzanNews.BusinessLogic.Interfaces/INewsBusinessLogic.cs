using DzanNews.BusinessModel.News;

namespace DzanNews.BusinessLogic.Interfaces
{
    public interface INewsBusinessLogic
    {
        List<GetNewsListResponse> GetNewsList(GetNewsListRequest request);
    }
}