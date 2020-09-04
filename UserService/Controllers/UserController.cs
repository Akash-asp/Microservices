using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Context;
using UserService.Model;
using UserService.Services.Infrastructure;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserApi _context;

        public UserController(IUserApi context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public User GetDemoApi(int id)
        {
            var demoApi = _context.GetUser(id);

           /* if (demoApi == null)
            {
                return NotFound();
            }
*/
            return demoApi;
        }
    }
}