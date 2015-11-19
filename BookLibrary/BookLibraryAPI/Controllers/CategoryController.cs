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
    public class CategoryController : ApiController
    {
        public void Post([FromBody]Models.Category category)
        {
            new Data.Context.Category(HostingEnvironment.MapPath("~")).add(category);
        }

        public List<Models.Category> Get()
        {
            return new Data.Context.Category(HostingEnvironment.MapPath("~")).get();
        }

        public Models.Category Get(Guid id)
        {
            return new Data.Context.Category(HostingEnvironment.MapPath("~")).get(id);
        }

        public void Put([FromBody]Models.Category category)
        {
            new Data.Context.Category(HostingEnvironment.MapPath("~")).update(category);
        }

        public void Delete(Guid id)
        {
            new Data.Context.Category(HostingEnvironment.MapPath("~")).delete(id);
        }
    }
}