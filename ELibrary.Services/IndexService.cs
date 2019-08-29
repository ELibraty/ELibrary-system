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

        public string SingUp(string userName, string password, string email, string type, string avatar)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                password = GetMd5Hash(md5Hash, password);
            }
            var user = new User()
            {
                UserName = userName,
                Password = password,
                Email = email,
                //Type = type,
                Avatar = avatar
            };

            context.Users.Add(user);
            context.SaveChanges();

            return user.Id;
        }

         public bool SingIn(string Email, string Password)
         {
             var user = this.context.Users.FirstOrDefault(x => x.Email == Email && x.Password == Password);
             if (user != null) return true;
             else return false;  
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
