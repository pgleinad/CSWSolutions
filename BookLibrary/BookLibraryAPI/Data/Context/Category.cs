using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryAPI.Data.Context
{
    public class Category
    {
        private string connectionString;
        private XmlMappingSource mapping;

        public Category(string serverPath)
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["BookLibrary"].ConnectionString;
            mapping = XmlMappingSource.FromUrl(serverPath + "/Data/Mapping/Category.xml");
        }

        public void add(Models.Category category)
        {
            using (BookLibrary dc = new BookLibrary(connectionString, mapping))
            {
                dc.addCategory(category.Id, category.name, category.description);
            }
        }

        public List<Models.Category> get()
        {
            List<Models.Category> categories = new List<Models.Category>();
            using (BookLibrary dc = new BookLibrary(connectionString, mapping))
            {
                IEnumerable<Models.Category> allCategories = from c in dc.GetTable<Models.Category>() select c;
                foreach (var category in allCategories)
                {
                    categories.Add(category);
                }
            }
            return categories;
        }

        public Models.Category get(Guid id)
        {
            Models.Category category = null;
            using (BookLibrary dc = new BookLibrary(connectionString, mapping))
            {
                IEnumerable<Models.Category> allCategories = from c in dc.GetTable<Models.Category>() where c.Id == id select c;
                category = allCategories.FirstOrDefault();
            }
            return category;
        }

        public void update(Models.Category category)
        {
            using (BookLibrary dc = new BookLibrary(connectionString, mapping))
            {
                var original = from c in dc.GetTable<Models.Category>() where c.Id == category.Id select c;
                dc.updateCategory(category.Id, category.name, category.description);
            }
        }

        public void delete(Guid id)
        {
            using (BookLibrary dc = new BookLibrary(connectionString, mapping))
            {
                dc.removeCategory(id);
            }
        }
    }
}