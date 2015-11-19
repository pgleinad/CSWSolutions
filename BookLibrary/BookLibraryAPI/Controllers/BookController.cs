using BookLibraryAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Web.Http;

namespace BookLibraryAPI.Controllers
{
    public class BookController : ApiController
    {


        public void Post([FromBody]Models.Book book)
        {
            new Data.Context.Book(HostingEnvironment.MapPath("~")).add(book);
        }

        public List<Models.Book> Get()
        {
            return new Data.Context.Book(HostingEnvironment.MapPath("~")).get();
        }

        public Models.Book Get(Guid id)
        {
            return new Data.Context.Book(HostingEnvironment.MapPath("~")).get(id);
        }

        public List<Models.Book> GetByAuthor(Guid authorId)
        {
            return new Data.Context.Book(HostingEnvironment.MapPath("~")).getByAuthor(authorId);
        }

        public List<Models.Book> GetByCategory(Guid categoryId)
        {
            return new Data.Context.Book(HostingEnvironment.MapPath("~")).getByCategory(categoryId);
        }

        public void Put([FromBody]Models.Book book)
        {
            new Data.Context.Book(HostingEnvironment.MapPath("~")).update(book);
        }

        public void Delete(Guid id)
        {
            new Data.Context.Book(HostingEnvironment.MapPath("~")).delete(id);
        }
    }
}