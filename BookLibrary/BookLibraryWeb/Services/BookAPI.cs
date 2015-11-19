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
    public class BookAPI
    {
        RestClient client;
        string webapiurl;

        public BookAPI()
        {
            webapiurl = ConfigurationManager.AppSettings["webapiurl"];
            client = new RestClient(webapiurl);
        }

        public List<Book> get()
        {
            var request = new RestRequest("api/Book", Method.GET) { RequestFormat = DataFormat.Json };
            var response = client.Execute<List<Book>>(request);
            return response.Data;
        }

        public Book get(Guid id)
        {
            var request = new RestRequest("api/Book/"+id.ToString(), Method.GET) { RequestFormat = DataFormat.Json };
            var response = client.Execute<Book>(request);
            return response.Data;
        }

        public List<Book> getByAuthor(Guid authorId)
        {
            var request = new RestRequest("api/Book?authorId="+authorId.ToString(), Method.GET) { RequestFormat = DataFormat.Json };
            var response = client.Execute<List<Book>>(request);
            return response.Data;
        }

        public void add(BookLibraryAPI.Models.Book book)
        {
            var request = new RestRequest("api/Book", Method.POST) { RequestFormat = DataFormat.Json };
            request.AddBody(book);
            client.Execute<List<Book>>(request);
        }

        public void update(BookLibraryAPI.Models.Book book)
        {
            var request = new RestRequest("api/Book", Method.PUT) { RequestFormat = DataFormat.Json };
            request.AddBody(book);
            client.Execute<List<Book>>(request);
        }

        public void delete(Guid id)
        {
            var request = new RestRequest("api/Book/"+id.ToString(), Method.DELETE) { RequestFormat = DataFormat.Json };
            client.Execute<List<Book>>(request);
        }
    }
}
