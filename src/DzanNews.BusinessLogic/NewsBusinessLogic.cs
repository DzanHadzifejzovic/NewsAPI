using AutoMapper;
using DzanNews.BusinessLogic.Interfaces;
using DzanNews.BusinessModel.News;
using DzanNews.DataModel.News;
using DzanNews.Services.Interfaces;

namespace DzanNews.BusinessLogic
{
    public class NewsBusinessLogic : INewsBusinessLogic
    {
        private readonly INewsService _newsService;
        private readonly IMapper _mapper;

        public NewsBusinessLogic(INewsService newsService,IMapper mapper)
        {
            _newsService = newsService;
            _mapper = mapper;
        }
        public List<GetNewsListResponse> GetNewsList(GetNewsListRequest request)
        {
            List<GetNewsListResponse> result = new List<GetNewsListResponse>();

            GetNewsRequestSP serviceRequest = _mapper.Map<GetNewsRequestSP>(request);
            List<GetNewsResponseSP> serviceResponse =_newsService.GetNews(serviceRequest);

            result = _mapper.Map<List<GetNewsListResponse>>(serviceResponse);

            return result;
        }
    }
}