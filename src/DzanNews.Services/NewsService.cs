using Dapper;
using DzanNews.DataModel;
using DzanNews.DataModel.News;
using DzanNews.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DzanNews.Services
{
    public class NewsService:INewsService
    {
        private readonly IConfiguration _configuration;
        private readonly string _connString;

        public NewsService(IConfiguration configuration)
        {
            _configuration = configuration;
            _connString = configuration.GetConnectionString("DzanNewsConn");
        }

        public string EditNews()
        {
            throw new NotImplementedException();
        }

        public List<GetNewsResponseSP> GetNews(GetNewsRequestSP request)
        {
            List<GetNewsResponseSP> response = new List<GetNewsResponseSP>();
            try
            {
                string query = "GetNewsList";
                using(var sqlConn = new SqlConnection(_connString))
                {
                    response = sqlConn.Query<GetNewsResponseSP>(query, request,
                                           commandType:CommandType.StoredProcedure).AsList();

                }
                return response;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string InsertNews()
        {
            throw new NotImplementedException();
        }
    }
}