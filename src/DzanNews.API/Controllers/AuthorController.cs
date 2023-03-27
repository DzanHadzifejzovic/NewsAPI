using DzanNews.BusinessLogic.Interfaces;
using DzanNews.BusinessModel;
using DzanNews.BusinessModel.Author;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DzanNews.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorBusinessLogic _authorBusinessLogic;

        public AuthorController(IAuthorBusinessLogic authorBusinessLogic)
        {
            _authorBusinessLogic = authorBusinessLogic;
        }

        [HttpGet]
        public IActionResult Get()
        {
            CommandResponse<List<Author>> authors = _authorBusinessLogic.GetAuthors();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            CommandResponse<Author> author = _authorBusinessLogic.GetAuthorById(id);
            return Ok(author);
        }

        [HttpPost]
        public IActionResult Post(InsertAuthorRequest author)
        {
           CommandResponse<Author> result =  _authorBusinessLogic.InsertAuthor(author);
           return Ok(result);
        }


    }
}
