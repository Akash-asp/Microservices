using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UserService.Context;
using UserService.Model;
using UserService.Services.Infrastructure;

namespace UserService.Services.DataServices
{
   public class UserApi : IUserApi
    {

        private readonly UserApiContext _context;

        public UserApi(UserApiContext context)
        {
            _context = context;
        }


        public List<User> GetUser()
        {
            throw new NotImplementedException();
        }

        public User GetUser(int ID)
        {
            return _context.User.FirstOrDefault(e=>e.ID==ID);
        }
    }
}
