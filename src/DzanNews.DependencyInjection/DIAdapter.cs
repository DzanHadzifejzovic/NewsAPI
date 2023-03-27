using DzanNews.BusinessLogic;
using DzanNews.BusinessLogic.Interfaces;
using DzanNews.Services;
using DzanNews.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DzanNews.DependencyInjection
{
    public static class DIAdapter
    {
        public static void AddMyServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped<INewsService,NewsService>();
            services.AddScoped<INewsBusinessLogic, NewsBusinessLogic>();

            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryBusinessLogic, CategoryBusinessLogic>();

            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IAuthorBusinessLogic, AuthorBusinessLogic>();
        }
    }
}