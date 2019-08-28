using ELibrary.Data;
using ELibrary.Data.Models;
using ELibrary.Services.Contracts;
using System;
using System.Linq;

namespace ELibrary.Services
{
    public class IndexService : IIndexService
    {
        private ELibraryDbContext context;

        public IndexService(ELibraryDbContext context)
        {
            this.context = context;
        }

        public int SingUp(string userName, string password, string email, string type, string avatar)
        {
            var user = new User()
            {
                UserName = userName,
                Password = password,
                Email = email,
                Type = type,
                Avatar = avatar
            };

            context.Users.Add(user);
            context.SaveChanges();

            return user.Id;
        }

       /* public bool SingIn(string Email, string Password)
        {
            var user = this.context.Users.FirstOrDefault(x => x.Email == Email && x.Password == Password);
            if (user != null) return true;
            else return false;
        }*/
    }
}
