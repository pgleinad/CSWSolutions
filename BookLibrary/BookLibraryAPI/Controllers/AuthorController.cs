using BookLibraryAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Hosting;
using System.Web.Http;

namespace BookLibraryAPI.Controllers
{
    public class AuthorController : ApiController
    {
        public void Post([FromBody]Models.Author author)
        {
            new Data.Context.Author(HostingEnvironment.MapPath("~")).add(author);
        }

        public List<Models.Author> Get()
        {
            return new Data.Context.Author(HostingEnvironment.MapPath("~")).get();
        }

        public Models.Author Get(Guid id)
        {
            return new Data.Context.Author(HostingEnvironment.MapPath("~")).get(id);
        }

        public void Put([FromBody]Models.Author author)
        {
            new Data.Context.Author(HostingEnvironment.MapPath("~")).update(author);
        }

        public void Delete(Guid id)
        {
            new Data.Context.Author(HostingEnvironment.MapPath("~")).delete(id);
        }
    }
}