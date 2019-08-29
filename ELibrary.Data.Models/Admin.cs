using System;
using System.Collections.Generic;
using System.Text;

namespace ELibrary.Data.Models
{
    public class Admin
    {

        public int Id { get; set; }

        public int UserId { get; set; }

        public User Users { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }


    }
}
