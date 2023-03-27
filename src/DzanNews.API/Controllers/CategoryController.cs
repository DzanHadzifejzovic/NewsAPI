
using DzanNews.BusinessLogic.Interfaces;
using DzanNews.BusinessModel;
using DzanNews.BusinessModel.Category;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DzanNews.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryBusinessLogic _categoryBusinessLogic;

        public CategoryController(ICategoryBusinessLogic categoryBusinessLogic)
        {
            _categoryBusinessLogic = categoryBusinessLogic;
        }

        [HttpGet]
        public IActionResult Get()
        {
            CommandResponse<List<Category>> category = _categoryBusinessLogic.GetCategories();
            return Ok(category);

        }

        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {
            CommandResponse<Category> category =  _categoryBusinessLogic.GetCategoryById(id);
            return Ok(category);

        }

        [HttpPost]
        public IActionResult Post(InsertCategoryRequest category)
        {
          var result =  _categoryBusinessLogic.InsertCategory(category);
          return Ok(result); 
        }
    }
}
