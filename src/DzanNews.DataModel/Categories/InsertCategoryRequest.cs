using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzanNews.DataModel.Categories
{
    public class InsertCategoryRequest //za slanje kao parametar
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
