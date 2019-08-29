using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
namespace ELibrary.Data.Models
{
    public class User : IdentityUser
    {
        public User()
        {
            this.CreatOn = DateTime.UtcNow;
            this.GetBooks = new List<GetBook>();
            this.AddedBooks = new List<Book>();

        }


        public string Password { get; set; }
        

        public string Avatar { get; set; }

        public DateTime CreatOn { get; set; }

        public DateTime? DeleteDate { get; set; }

        public ICollection<GetBook> GetBooks { get; set; }

        public ICollection<Book> AddedBooks { get; set; }



    }
}
