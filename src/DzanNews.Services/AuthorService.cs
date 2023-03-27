using Dapper;
using DzanNews.DataModel.Author;
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
    public class AuthorService : IAuthorService
    {
        private readonly IConfiguration _configuration;
        private readonly string _connString;
        public AuthorService(IConfiguration configuration)
        {
            _configuration = configuration;
            _connString = configuration.GetConnectionString("DzanNewsConn");
        }

        public List<Author> GetAuthors()
        {
            List<Author> authors = new  List<Author>();
            string query = "GetAuthors";
            using (var sqlConn = new SqlConnection(_connString))
            {
                authors = sqlConn.Query<Author>(query,commandType:CommandType.StoredProcedure).ToList();
            }
           
            return authors;
        }

        public Author GetAuthorById(int AuthorId)
        {
            Author author = new Author();
            try
            {
                string query = "GetAuthorById";
                using (var sqlConn = new SqlConnection(_connString))
                {
                    author = sqlConn.Query<Author>(query,
                                                        new { AuthorId },
                                                        commandType: CommandType.StoredProcedure).FirstOrDefault();

                }
                return author;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public Author InsertAuthor(InsertAuthorRequest request)
        {
            Author newAuthor= new Author();
            try
            {
                string query = "InsertAuthor";
                using (var sqlConn = new SqlConnection(_connString))
                {
                    newAuthor = sqlConn.Query<Author>(query,
                                                        request,
                                                        commandType: CommandType.StoredProcedure).FirstOrDefault();

                }
                return newAuthor;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
