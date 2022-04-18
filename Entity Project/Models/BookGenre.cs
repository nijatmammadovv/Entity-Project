using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Project.Models
{
    class BookGenre
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int GenreId { get; set; }
        public Book Book { get; set; }
        public Genre Genre { get; set; }
        public List<BookGenre> BookGenres { get; set; }
    }
}
