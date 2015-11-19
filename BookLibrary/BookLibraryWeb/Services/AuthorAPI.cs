using BookLibraryAPI.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace BookLibraryWeb.Services
{
    public class AuthorAPI
    {
        RestClient client;
        string webapiurl;

        public AuthorAPI()
        {
            webapiurl = ConfigurationManager.AppSettings["webapiurl"];
            client = new RestClient(webapiurl);
        }

        public List<Author> get()
        {
            var request = new RestRequest("api/Author", Method.GET) { RequestFormat = DataFormat.Json };
            var response = client.Execute<List<Author>>(request);
            return response.Data;
        }

        public Author get(Guid id)
        {
            var request = new RestRequest("api/Author/"+id.ToString(), Method.GET) { RequestFormat = DataFormat.Json };
            var response = client.Execute<Author>(request);
            return response.Data;
        }

        public void add(BookLibraryAPI.Models.Author author)
        {
            var request = new RestRequest("api/Author", Method.POST) { RequestFormat = DataFormat.Json };
            request.AddBody(author);
            client.Execute<List<Author>>(request);
        }

        public void update(BookLibraryAPI.Models.Author author)
        {
            var request = new RestRequest("api/Author", Method.PUT) { RequestFormat = DataFormat.Json };
            request.AddBody(author);
            client.Execute<List<Author>>(request);
        }

        public void delete(Guid id)
        {
            var request = new RestRequest("api/Author/"+id.ToString(), Method.DELETE) { RequestFormat = DataFormat.Json };
            client.Execute<List<Author>>(request);
        }
    }
}