using Microsoft.AspNetCore.Mvc;

namespace Homework12.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class ServicesController : ControllerBase
{
    private readonly OrderService service;
    private readonly ILogger<ServicesController> _logger;

    public ServicesController(ILogger<ServicesController> logger)
    {
        _logger = logger;
        service = new OrderService();
    }

    [HttpGet]
    public string GetID()
    {
        return "123456";
    }
/*
    [HttpGet("{id}")]
    public string SetID(int id)
    {
        using (var ctx = new OrderContext())
        {
            var order = ctx.Orders.FirstOrDefault();
            if (order != null)
                ctx.Orders.Remove(order);
            ctx.Orders.Add(new Order($"{id}"));
            ctx.SaveChanges();
        }
        return $"id in url is {id}";
    }*/

    [HttpGet("{id}")]
    public ActionResult<Order> GetOrder(string id)
    {
        return service.GetOrder(id);
    }

    [HttpPost]
    public ActionResult AddOrder(Order order)
    {
        service.AddOrder(order);
        return NoContent();
    }
}
