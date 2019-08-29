using System;
using System.Collections.Generic;
using System.Text;

namespace ELibrary.Data.Models
{
    public class Person
    {

        public string Id { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
