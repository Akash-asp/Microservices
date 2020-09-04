using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
       
        private readonly ILogger<OrdersController> _logger;

        public OrdersController(ILogger<OrdersController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{ID}")]
        public IEnumerable<Orders> Get(int ID)
        {
            Orders[] obj = new Orders[]
            {
                new Orders()
                {
                        orderId = 1,
                            orderAmount = 250,
                            orderDate ="14-Apr-2020"
                    },
                    new Orders()
                    {
                        orderId = 2,
                            orderAmount = 500,
                            orderDate = "15-Apr-2020"
                    }
            };
            return obj; 
        }
    }
}
