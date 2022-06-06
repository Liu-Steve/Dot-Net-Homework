using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderContext orderDb;

        //构造函数把OrderContext作为参数，Asp.net core框架可以自动注入OrderContext对象
        public OrderController(OrderContext context)
        {
            this.orderDb = context;
        }

        //GET:api/order
        [HttpGet]
        public ActionResult<List<Order>> GetOrder()
        {
            IQueryable<Order> query = orderDb.Orders;            
            query = query.Where(t => t.OrderId != -1);
            return query.ToList();
        }
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(int id)
        {
            var order = orderDb.Orders.FirstOrDefault(testc => testc.OrderId == id);
            if(order==null)
            {
                return NotFound();
            }
            return order;
        }

        [HttpPost]
        public ActionResult<Order> PostOrder(Order order)
        {
            try
            {
                orderDb.Orders.Add(order);
                orderDb.SaveChanges();
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }

        [HttpPut("{id}")]
        public ActionResult<Order> PutOrder(int id,Order order)
        {
            if(id!=order.OrderId)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                orderDb.Entry(order).State = EntityState.Modified;
                orderDb.SaveChanges();
            }
            catch(Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null)
                    error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(int id)
        {
            try
            {
                var order = orderDb.Orders.FirstOrDefault(t => t.OrderId == id);
                if(order!=null)
                {
                    orderDb.Remove(order);
                    orderDb.SaveChanges();
                }
            }
            catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }
    }
}
