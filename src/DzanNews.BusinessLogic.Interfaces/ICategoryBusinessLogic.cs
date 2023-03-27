using DzanNews.BusinessModel;
using DzanNews.BusinessModel.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzanNews.BusinessLogic.Interfaces
{
    public interface ICategoryBusinessLogic
    {
        CommandResponse<List<Category>> GetCategories();
        CommandResponse<Category> GetCategoryById(int id);
        CommandResponse<Category> InsertCategory(InsertCategoryRequest request);
    }
}
