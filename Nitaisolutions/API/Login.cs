using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nitaisolutions.NitaiDB;
using Nitaisolutions.Models;

namespace Nitaisolutions
{
    
    
    public class LoginAPI
    {
        DBEngine DBE = new DBEngine();
    
    public string ValidateLogin(Userinfo FUser)
        {
            var currentuser = (from user in DBE.Users
                               where user.UserName == FUser.UserName && user.Password == FUser.Password
                               select user).FirstOrDefault<Userinfo>();

            return currentuser.ToString();

        }
    }
}