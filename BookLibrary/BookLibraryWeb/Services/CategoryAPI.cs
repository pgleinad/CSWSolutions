using BookLibraryAPI.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryWeb.Services
{
    public class CategoryAPI
    {
        RestClient client;
        string webapiurl;

        public CategoryAPI()
        {
            webapiurl = ConfigurationManager.AppSettings["webapiurl"];
            client = new RestClient(webapiurl);
        }

        public List<Category> get()
        {
            var request = new RestRequest("api/Category", Method.GET) { RequestFormat = DataFormat.Json };
            var response = client.Execute<List<Category>>(request);
            return response.Data;
        }

        public Category get(Guid id)
        {
            var request = new RestRequest("api/Category/"+id.ToString(), Method.GET) { RequestFormat = DataFormat.Json };
            var response = client.Execute<Category>(request);
            return response.Data;
        }

        public void add(BookLibraryAPI.Models.Category category)
        {
            var request = new RestRequest("api/Category", Method.POST) { RequestFormat = DataFormat.Json };
            request.AddBody(category);
            client.Execute<List<Category>>(request);
        }

        public void update(BookLibraryAPI.Models.Category category)
        {
            var request = new RestRequest("api/Category", Method.PUT) { RequestFormat = DataFormat.Json };
            request.AddBody(category);
            client.Execute<List<Category>>(request);
        }

        public void delete(Guid id)
        {
            var request = new RestRequest("api/Category/"+id.ToString(), Method.DELETE) { RequestFormat = DataFormat.Json };
            client.Execute<List<Category>>(request);
        }
    }
}
