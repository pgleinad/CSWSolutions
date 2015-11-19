using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryAPI.Data.Context
{
    public class Book
    {
        private string connectionString;
        private XmlMappingSource mapping;

        public Book(string serverPath)
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["BookLibrary"].ConnectionString;
            mapping = XmlMappingSource.FromUrl(serverPath + "/Data/Mapping/Book.xml");
        }

        public void add(Models.Book book)
        {
            using (BookLibrary dc = new BookLibrary(connectionString, mapping))
            {
                dc.addBook(book.id, book.name, book.authorId, book.categoryId);
            }
        }

        public List<Models.Book> get()
        {
            List < Models.Book > books = new List<Models.Book>();
            using (BookLibrary dc = new BookLibrary(connectionString, mapping))
            {
                IEnumerable<Models.Book> allBooks = from b in dc.GetTable<Models.Book>() select b;
                foreach (var book in allBooks)
                {
                    books.Add(book);
                }
            }
            return books;
        }

        public Models.Book get(Guid id)
        {
            Models.Book book = null;
            using (BookLibrary dc = new BookLibrary(connectionString, mapping))
            {
                IEnumerable<Models.Book> allBooks = from b in dc.GetTable<Models.Book>() where b.id == id select b;
                book = allBooks.FirstOrDefault();
            }
            return book;
        }

        public List<Models.Book> getByAuthor(Guid authorId)
        {
            return get().Where(b => b.authorId == authorId).ToList();
        }

        public List<Models.Book> getByCategory(Guid categoryId)
        {
            return get().Where(b => b.categoryId == categoryId).ToList();
        }

        public void update(Models.Book book)
        {
            using (BookLibrary dc = new BookLibrary(connectionString, mapping))
            {
                var original = from b in dc.GetTable<Models.Book>() where b.id == book.id select b;
                dc.updateBook(book.id, book.name, book.authorId, book.categoryId);
            }
        }

        public void delete(Guid id)
        {
            using (BookLibrary dc = new BookLibrary(connectionString, mapping))
            {
                dc.removeBook(id);
            }
        }
    }
}