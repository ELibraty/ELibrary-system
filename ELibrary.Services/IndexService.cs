using ELibrary.Data;
using ELibrary.Data.Models;
using ELibrary.Services.Contracts;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Security.Cryptography;

namespace ELibrary.Services
{
    public class IndexService : IIndexService
    {
        private ELibraryDbContext context;

        public IndexService(ELibraryDbContext context)
        {
            this.context = context;
        }

        public string SingUp(string UserName, string Password, string Email, string Avatar)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                Password = GetMd5Hash(md5Hash, Password);
            }
            var user = new User()
            {
                UserName = UserName,
                Password = Password,
                Email = Email,
                //Type = type,
                Avatar = Avatar
            };

            context.Users.Add(user);
            context.SaveChanges();

            return user.Id;
        }

         public string SingIn(string userName, string password)
         {
            using (MD5 md5Hash = MD5.Create())
            {
                password = GetMd5Hash(md5Hash, password);
            }
            var user = this.context.Users.FirstOrDefault(x => x.UserName == userName && x.Password == password);
        
            if (user != null) return "";
            else return "Admin";  
         }

        //do pass to MD5
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }  
}
