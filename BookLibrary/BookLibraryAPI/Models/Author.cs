namespace BookLibraryAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Author
    {
        public Guid Id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
