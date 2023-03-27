using AutoMapper;
using DzanNews.BusinessModel.Author;
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
    public class BusinessModel2DataModel:Profile
    {
        public BusinessModel2DataModel()
        {
            this.CreateMap<GetNewsListRequest, GetNewsRequestSP>();
            this.CreateMap<GetNewsListResponse, GetNewsResponseSP>();

           // this.CreateMap<Category,DataModel.Categories.Category>();
            this.CreateMap<InsertCategoryRequest, DataModel.Categories.InsertCategoryRequest>();

            this.CreateMap<InsertAuthorRequest, DataModel.Author.InsertAuthorRequest>();
        }
    }
}
