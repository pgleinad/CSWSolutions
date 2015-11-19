using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Reflection;

namespace BookLibraryAPI.Data
{
    using System.Data.Entity;
    using Models;
    using System.Threading.Tasks;

    public partial class BookLibrary : DataContext
    {
        public BookLibrary(string connectionString, XmlMappingSource xmlMap) : base(connectionString, xmlMap) { }

        public int addAuthor(Guid id, string name)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, name);
            return (int)result.ReturnValue;
        }

        public int updateAuthor(Guid id, string name)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, name);
            return (int)result.ReturnValue;
        }

        public int removeAuthor(Guid id)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
            return (int)result.ReturnValue;
        }

        public int addCategory(Guid id, string name, string description)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, name, description);
            return (int)result.ReturnValue;
        }

        public int updateCategory(Guid id, string name, string description)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, name, description);
            return (int)result.ReturnValue;
        }

        public int removeCategory(Guid id)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
            return (int)result.ReturnValue;
        }

        public int addBook(Guid id, string name, Guid authorId, Guid categoryId)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, name, authorId, categoryId);
            return (int)result.ReturnValue;
        }

        public int updateBook(Guid id, string name, Guid authorId, Guid categoryId)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, name, authorId, categoryId);
            return (int)result.ReturnValue;
        }

        public int removeBook(Guid id)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
            return (int)result.ReturnValue;
        }
    }
}
