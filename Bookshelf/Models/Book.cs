using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Bookshelf.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }

        [ForeignKey("Category")] // foreign key sets up the relationship (in this case, one to many)
        public int CategoryID { get; set; }
        public virtual Category Category {get; set;} // navigation property -- in a one to many relationship, there are 2 navigation properties

    }
}