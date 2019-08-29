using System;
using System.Collections.Generic;
using System.Text;

namespace ELibrary.Data.Models
{
    public class Book
    {
        public Book()
        {
            this.CreatOn = DateTime.UtcNow;
        }

        public int Id { get; set; }

        public string BookName { get; set; }

        public string Author { get; set; }

        public string GenreId { get; set; }
        
        public Genre Genres { get; set; }

        public string BookCode { get; set; }

        public int UserId { get; set; }

        public User Users { get; set; }

        public DateTime CreatOn { get; set; }

        public DateTime? DeleteDate { get; set; }


    }
}
