using DzanNews.BusinessModel;
using DzanNews.BusinessModel.Author;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzanNews.BusinessLogic.Interfaces
{
    public interface IAuthorBusinessLogic
    {
        CommandResponse<List<Author>> GetAuthors();
        CommandResponse<Author> InsertAuthor(InsertAuthorRequest request);
        CommandResponse<Author> GetAuthorById(int id);
    }
}
