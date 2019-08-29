using System;
using System.Collections.Generic;
using System.Text;

namespace ELibrary.Services.Contracts
{
    public interface IIndexService
    {
        string SingUp(string UserName, string Password, string Email, string Type, string Avatar);

//        bool SingIn(string Password, string Email);

    }
}
