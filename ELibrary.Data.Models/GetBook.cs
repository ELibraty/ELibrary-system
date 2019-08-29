using System;
using System.Collections.Generic;
using System.Text;

namespace ELibrary.Data.Models
{
    public class GetBook
    {
        public GetBook()
        {
            this.CreatOn = DateTime.UtcNow;
            this.Books = new List<Book>();
        }

        public string Id { get; set; }

        public string UserId { get; set; }

        public User Users { get; set; }

        public string BookId { get; set; }

        public ICollection<Book> Books { get; set; }

        public DateTime CreatOn { get; set; }

        public DateTime? ReturnDate { get; set; }

    }
}
