using DzanNews.BusinessLogic.Interfaces;
using DzanNews.BusinessModel.News;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DzanNews.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsBusinessLogic _businessLogic;

        public NewsController(INewsBusinessLogic businessLogic)
        {
           _businessLogic = businessLogic;
        }

        [HttpPost]
        public IActionResult Get(GetNewsListRequest request)
        {
            var result = _businessLogic.GetNewsList(request);
            return Ok(result);
        }
    }
}
