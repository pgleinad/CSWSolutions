namespace BookLibraryAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Book
    {
        public Guid id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public Guid authorId { get; set; }

        public Guid categoryId { get; set; }

        public virtual Author Author { get; set; }

        public virtual Category Category { get; set; }
    }
}
