﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ELibrary.Data.Models
{
    public class Person
    {

        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
