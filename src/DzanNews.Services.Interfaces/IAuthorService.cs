using DzanNews.DataModel.Author;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzanNews.Services.Interfaces
{
    public interface IAuthorService
    {
        List<Author> GetAuthors();
        Author InsertAuthor(InsertAuthorRequest request);
        Author GetAuthorById(int AuthorId);

    }
}
