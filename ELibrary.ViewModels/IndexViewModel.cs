using System;
using System.ComponentModel.DataAnnotations;

namespace ELibrary.ViewModels
{
    public class IndexViewModel 
    {
        //SingUp
        [Required(ErrorMessage ="Моля въведете потребителско име!")]
        [MaxLength(10)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Моля въведете парола!")]
        [DataType(DataType.Password, ErrorMessage = "Моля въведете парола!")]
        [MaxLength(20)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Моля повторете парола!")]
        [DataType(DataType.Password, ErrorMessage = "Моля повторете парола!")]
        [Compare(nameof(Password), ErrorMessage = "Паролите не съвпадат!")]
        [MaxLength(20)]
        public string ConfrimPassword { get; set; }

        [Required(ErrorMessage = "Моля въведете потребителско име!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Моля въведете валиден e-mail адрес!")]
        [MaxLength(20)]
        public string Email { get; set; }


        //Sing In
        //public string PasswordSingIn { get; set; }

        //public string EmailSingIn { get; set; }
    } 
}
