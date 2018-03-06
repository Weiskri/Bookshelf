using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookshelf.Models
{
    public class Category
    {
        [Key] 
        public int ID { get; set; } // this primary ID corresponds to the foreign key categoryID in book (the many table)
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; } // a category can have many books
    }
}