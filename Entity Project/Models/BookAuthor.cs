using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Project.Models
{
    class BookAuthor
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public Book Book { get; set; }
        public Author Author { get; set; }
    }
}
