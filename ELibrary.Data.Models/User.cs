using System;
using System.Collections.Generic;
using System.Text;

namespace ELibrary.Data.Models
{
    public class User
    {
        public User()
        {
            this.CreatOn = DateTime.UtcNow;
        }

        public int Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Type { get; set; }

        public string Avatar { get; set; }

        public DateTime CreatOn { get; set; }

        public DateTime? DeleteDate { get; set; }


    }
}
