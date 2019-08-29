using System;
using System.Collections.Generic;
using System.Text;

namespace ELibrary.Data.Models
{
    public class Library
    {

        public int Id { get; set; }

        public int UserId { get; set; }

        public User Users { get; set; }

        public string NameLibrary { get; set; }

        public string Location { get; set; }


    }
}
