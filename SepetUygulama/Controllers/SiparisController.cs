using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SepetUygulama.Models;
using SepetUygulama.Models.Repositories;

namespace SepetUygulama.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiparisController : ControllerBase
    {
        private readonly OrderRepo _or;

        public SiparisController(SepetAppContext context)
        {
            OrderRepo or = new OrderRepo(context);

            _or = or;
        }

       
        [HttpGet()]
        public ActionResult<List<Order>> GetOrderList()
        {
            var list = _or.GetAllOrderWithCustomerAndProduct();
            if (list == null)
            {
                return NotFound();
            }
            return list;
        }

        [HttpGet("{id}", Name = "GetOrderById")]
        public ActionResult<Order> GetOrderById(int id)
        {
            var item = _or.GetOrderByIdWithCustomerAndProduct(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        [HttpPost]
        public IActionResult CreateOrder(Order order)
        {
            var item = _or.CreateOrderwithCustomerandProduct(order);
            if (item == null)
            {
                return NotFound();
            }
            return Ok();
        
        }
    }
}