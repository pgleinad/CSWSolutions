using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryAPI.Data.Context
{
    public class Author
    {
        private string connectionString;
        private XmlMappingSource mapping;

        public Author(string serverPath)
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["BookLibrary"].ConnectionString;
            mapping = XmlMappingSource.FromUrl(serverPath + "/Data/Mapping/Author.xml");
        }

        public void add(Models.Author author)
        {
            using (BookLibrary dc = new BookLibrary(connectionString, mapping))
            {
                dc.addAuthor(author.Id, author.name);
            }
        }

        public List<Models.Author> get()
        {
            List<Models.Author> authors = new List<Models.Author>();
            using (BookLibrary dc = new BookLibrary(connectionString, mapping))
            {
                IEnumerable<Models.Author> allAuthors = from a in dc.GetTable<Models.Author>() select a;
                foreach (var author in allAuthors)
                {
                    authors.Add(author);
                }
            }
            return authors;
        }

        public Models.Author get(Guid id)
        {
            Models.Author author = null;
            using (BookLibrary dc = new BookLibrary(connectionString, mapping))
            {
                IEnumerable<Models.Author> allAuthors = from a in dc.GetTable<Models.Author>() where a.Id == id select a;
                author = allAuthors.FirstOrDefault();
            }
            return author;
        }

        public void update(Models.Author author)
        {
            using (BookLibrary dc = new BookLibrary(connectionString, mapping))
            {
                var original = from a in dc.GetTable<Models.Author>() where a.Id == author.Id select a;
                dc.updateAuthor(author.Id, author.name);
            }
        }

        public void delete(Guid id)
        {
            using (BookLibrary dc = new BookLibrary(connectionString, mapping))
            {
                dc.removeAuthor(id);
            }
        }
    }
}