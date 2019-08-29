using System;
using System.Collections.Generic;

namespace ELibrary.Data.Models
{
    public class Genre
    {
        public Genre()
        {
            this.Books = new List<Book>();
        }

        public string Id { get; set; }

        public string GenreName { get; set; }

        public ICollection<Book> Books { get; set; }

    }
}
