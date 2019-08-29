using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ELibrary.ViewModels
{
    public class IndexViewModel 
    {
        [Required(ErrorMessage = "Моля въведете потребителско име!")]
        [BindProperty]
        public SingUpModel SingUp { get; set; }

        [BindProperty]
        public SingInModel SingIn { get; set; }

        //SingUp
        public class SingUpModel
        {
            [Required(ErrorMessage = "Моля въведете потребителско име!")]
            [MaxLength(10)]
            public string UserNameSingUp { get; set; }

            [Required(ErrorMessage = "Моля въведете парола!")]
            [DataType(DataType.Password, ErrorMessage = "Моля въведете парола!")]
            [MaxLength(20)]
            public string PasswordSingUp { get; set; }

            [Required(ErrorMessage = "Моля повторете парола!")]
            [DataType(DataType.Password, ErrorMessage = "Моля повторете парола!")]
            [Compare(nameof(PasswordSingUp), ErrorMessage = "Паролите не съвпадат!")]
            [MaxLength(20)]
            public string ConfrimPasswordSingUp{ get; set; }

            [Required(ErrorMessage = "Моля въведете потребителско име!")]
            [DataType(DataType.EmailAddress, ErrorMessage = "Моля въведете валиден e-mail адрес!")]
            [MaxLength(20)]
            public string EmailSingUp { get; set; }
        }

        //Sing In

        public class SingInModel
        {
            [Required(ErrorMessage = "Моля въведете потребителско име!")]
            [MaxLength(10)]
            public string UserNameSingIn { get; set; }

            [Required(ErrorMessage = "Моля въведете парола!")]
            [DataType(DataType.Password, ErrorMessage = "Моля въведете парола!")]
            [MaxLength(20)]
            public string PasswordSingIn { get; set; }

           
        }
        //public string PasswordSingIn { get; set; }

        //public string EmailSingIn { get; set; }
    } 
}
