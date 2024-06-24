using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Faves.Models;

namespace Restaurant_Faves.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
            RestaurantDbContext dbContext = new RestaurantDbContext();

            //getall
            [HttpGet()]
            public IActionResult GetAll(string? res = null, bool? orderagain = null)
            {
                List<Order> result = dbContext.Orders.ToList();
                if (res != null)
                {
                    result = result.Where(r => r.Restaurant.ToLower().Contains(res.ToLower())).ToList();
                }
                if (orderagain != null)
                {
                    result = result.Where(o => o.OrderAgain == orderagain).ToList();
                }
                return Ok(result);
            }

            //getby id
            [HttpGet("{id}")]
            public IActionResult GetRestaurant(int id)
            {
                Order result = dbContext.Orders.Find(id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }

            //add Order
            [HttpPost]
            public IActionResult AddOrder([FromBody] Order newOrder)
            {
                newOrder.Id = 0;
                dbContext.Orders.Add(newOrder);
                dbContext.SaveChanges();
                return Created($"api/Orders/{newOrder.Id}", newOrder); //just returns it follow syntax but not necessart
            }

            //delete book
            [HttpDelete("{id}")]
            public IActionResult DeleteOrder(int id)
            {
                Order order = dbContext.Orders.Find(id);
                if (order == null)
                {
                    return NotFound();
                }
                dbContext.Orders.Remove(order);
                dbContext.SaveChanges();
                return NoContent();
            }

            //update order
            [HttpPut("{id}")]
            public IActionResult UpdateOrder(int id, [FromBody] Order updateOrder)
            {
                if (updateOrder.Id != id) { return BadRequest(); }
                if (!dbContext.Orders.Any(o => o.Id == id)) { return NotFound(); }
                dbContext.Orders.Update(updateOrder);
                dbContext.SaveChanges();
                return NoContent();

            }

    }
}
