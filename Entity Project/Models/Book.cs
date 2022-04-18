using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Project.Models
{
    class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public int StockCount { get; set; }
        public decimal Price { get; set; }
        public int PublisingId { get; set; }
        public Publising Publising { get; set; }
        public List<BookGenre> BookGenres { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }

    }
}
