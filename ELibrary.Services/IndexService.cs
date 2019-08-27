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

        public int SingUp(string UserName, string Password, string Email, string Type, string Avatar)
        {
            var user = new User()
            {
                UserName = UserName,
                Password = Password,
                Email = Email,
                Type = Type,
                Avatar = Avatar
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
