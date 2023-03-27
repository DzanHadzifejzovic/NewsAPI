using AutoMapper;
using DzanNews.BusinessLogic.Interfaces;
using DzanNews.BusinessModel;
using DzanNews.BusinessModel.Author;
using DzanNews.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzanNews.BusinessLogic
{
    public class AuthorBusinessLogic : IAuthorBusinessLogic
    {

        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public AuthorBusinessLogic(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public CommandResponse<List<Author>> GetAuthors()
        {
            CommandResponse <List<Author>> result = new CommandResponse<List<Author>>();

            try
            {
                List<DataModel.Author.Author> list = _authorService.GetAuthors();

                if (list != null)
                {

                    result.Data = _mapper.Map<List<Author>>(list);

                }
                else
                {
                    result.ErrorMessage = "Error in business logic";
                }

            }
            catch (Exception ex)
            {
                result.ErrorMessage = "General logic error";
            }

            return result;
        }

        public CommandResponse<Author> GetAuthorById(int id)
        {
            CommandResponse<Author> result = new CommandResponse<Author>();

            DataModel.Author.Author responseAuthor = _authorService.GetAuthorById(id);

            if (responseAuthor != null)
            {
                result.Data = _mapper.Map<Author>(responseAuthor);
            }
            else
            {
                result.ErrorMessage = "Error in business logic";
            }

            return result;
        }

        public CommandResponse<Author> InsertAuthor(InsertAuthorRequest request)
        {
          

            CommandResponse<Author> result = new CommandResponse<Author>();

            DataModel.Author.InsertAuthorRequest requestDM = _mapper.Map<DataModel.Author.InsertAuthorRequest>(request);

            DataModel.Author.Author authorDM = _authorService.InsertAuthor(requestDM);

            if (authorDM != null)
            {
                result.Data = _mapper.Map<Author>(authorDM);
            }
            else
            {
                result.ErrorMessage = "Error in business logic";
            }

            return result;
        }
    }
}
