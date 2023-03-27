using AutoMapper;
using DzanNews.BusinessModel.Category;
using DzanNews.BusinessModel.News;
using DzanNews.DataModel.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzanNews.Mapper
{
    public class DataModel2BusinessModel:Profile
    {
        public DataModel2BusinessModel()
        {
            this.CreateMap<GetNewsRequestSP,GetNewsListRequest>();
            this.CreateMap<GetNewsResponseSP,GetNewsListResponse>();

            this.CreateMap<DataModel.Categories.Category, Category>();
            //   this.CreateMap<DataModel.Categories.InsertCategoryRequest,InsertCategoryRequest>();

            this.CreateMap<DataModel.Author.Author,BusinessModel.Author.Author>();
        }
    }
}
