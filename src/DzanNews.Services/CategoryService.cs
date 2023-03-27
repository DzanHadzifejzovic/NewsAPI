using Dapper;
using DzanNews.DataModel.Categories;
using DzanNews.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzanNews.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IConfiguration _configuration;
        private readonly string _connString;
        public CategoryService(IConfiguration configuration)
        {
            _configuration = configuration;
            _connString = configuration.GetConnectionString("DzanNewsConn");
        }

        public List<Category> GetCategories()
        {
           List<Category> category = new List<Category>();
            try
            {
                string query = "GetCategories";
                using (var sqlConn = new SqlConnection(_connString))
                {
                    category = sqlConn.Query<Category>(query,commandType: CommandType.StoredProcedure).ToList();

                }
                return category;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Category GetCategoryById(int id)
        {
            Category category = new Category();
            try
            {
                string query = "GetCategory";
                using (var sqlConn = new SqlConnection(_connString))
                {
                    category = sqlConn.Query<Category>(query, //OBAVEZNO DA SE MATCH-UJE  imena property-ja Category klase sa kolonama u bazi 
                                                                 new {Id=id},     // ovo se matchuje sa parametrom u sp u bazi
                                                                 commandType: CommandType.StoredProcedure).FirstOrDefault();

                }
                return category;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Category InsertCategory(InsertCategoryRequest category)
        {
            Category newCategory = new Category();
            try
            {
                string query = "InsertCategory";
                using (var sqlConn = new SqlConnection(_connString))
                {
                    newCategory = sqlConn.Query<Category>(query, 
                                                        category,
                                                        commandType: CommandType.StoredProcedure).FirstOrDefault();

                }
                return newCategory;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
