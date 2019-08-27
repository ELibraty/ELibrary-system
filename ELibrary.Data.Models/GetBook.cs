﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ELibrary.Data.Models
{
    public class GetBook
    {
        public GetBook()
        {
            this.CreatOn = DateTime.UtcNow;
        }

        public int Id { get; set; }

        public int UserId { get; set; }

        public ICollection<User> Users { get; set; }

        public int BookId { get; set; }

        public ICollection<Book> Books { get; set; }

        public DateTime CreatOn { get; set; }

        public DateTime? ReturnDate { get; set; }

    }
}
