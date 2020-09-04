using System;
using System.Collections.Generic;
using System.Text;
using UserService.Model;

namespace UserService.Services.Infrastructure
{
 public   interface IUserApi
    {
        List<User> GetUser();

        User GetUser(int ID);
    }
}
