﻿using System;
using System.Collections.Generic;
using System.Text;
using ELibrary.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ELibrary.Data
{
    public class ELibraryDbContext : IdentityDbContext<User>
    {
        public ELibraryDbContext(DbContextOptions<ELibraryDbContext> options)
           : base(options)
        {
        }
        

        public DbSet<Genre> Genres { get; set; }


        public DbSet<Admin> Admin { get; set; }

        public DbSet<Library> Library { get; set; }

        public DbSet<Person> Person { get; set; }
        
        public DbSet<Book> Books { get; set; }

        public DbSet<GetBook> GetBooks { get; set; }

        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationData.ConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
