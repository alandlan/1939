using BookStores.Context;
using BookStores.Repositories;
using BookStores.Repositories.Contracts;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace BookStores
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<BookStoreDataContext, BookStoreDataContext>();
            container.RegisterType<IAuthorRepository, AuthorRepository>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}