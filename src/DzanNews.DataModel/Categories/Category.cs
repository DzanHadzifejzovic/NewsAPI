using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzanNews.DataModel.Categories
{
    public class Category //povrtana vrijednost obe metode iz CategoryService-a
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public string? Description { get; set; } //u bazi je allow null
    }
}
