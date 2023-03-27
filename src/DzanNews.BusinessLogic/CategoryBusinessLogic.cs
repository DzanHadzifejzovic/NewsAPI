using AutoMapper;
using DzanNews.BusinessLogic.Interfaces;
using DzanNews.BusinessModel;
using DzanNews.BusinessModel.Category;
using DzanNews.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzanNews.BusinessLogic
{
    public class CategoryBusinessLogic : ICategoryBusinessLogic
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryBusinessLogic(ICategoryService categoryService,IMapper mapper )
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public CommandResponse<List<Category>> GetCategories()
        {
            CommandResponse<List<Category>> result = new CommandResponse<List<Category>>();

            try
            { 
                    var categoryDM = _categoryService.GetCategories();
                    if (categoryDM != null)
                    {
                        result.Data = _mapper.Map<List<Category>>(categoryDM);
                    }
                    else
                    {
                        result.ErrorMessage = "Error in business logic";
                    }
            }
            catch (Exception ex)
            {
                result.ErrorMessage = "General logic error";
                //todo log error
            }
            return result;
        }

        public CommandResponse<Category> GetCategoryById(int id)
        {
            CommandResponse<Category> result = new CommandResponse<Category>();
            
            DataModel.Categories.Category categoryDM =  _categoryService.GetCategoryById(id);
            if(categoryDM != null)
            {
                result.Data =  _mapper.Map<Category>(categoryDM);
            }
            else
            {
                result.ErrorMessage = "Error in business logic";
            }

            return result;
        }

        public CommandResponse<Category> InsertCategory(InsertCategoryRequest request)
        {
            CommandResponse<Category> result = new CommandResponse<Category>();

            DataModel.Categories.InsertCategoryRequest requestDM = _mapper.Map<DataModel.Categories.InsertCategoryRequest>(request);
            
            DataModel.Categories.Category categoryDM = _categoryService.InsertCategory(requestDM);
            
            if(categoryDM != null)
            {
                result.Data = _mapper.Map<Category>(categoryDM);
            }
            else
            {
                result.ErrorMessage = "Error in business logic";
            }

           // result = _mapper.Map<CommandResponse<Category>>(categoryDM);

            return result;
             

        }
    }
}
