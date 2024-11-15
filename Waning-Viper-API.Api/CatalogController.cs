using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Waning_Viper_API.Domain.Catalog;

namespace Waning_Viper_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public IActionResult GetItems()
        {
            var items = new List<Item>()
            {
                new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m),
                new Item("Shorts", "Ohio State shorts.", "Nike", 44.99m)
            };
            return Ok(items);
        }

        [Authorize]
        [HttpGet("{id:int}")]
        public IActionResult GetItem(int id)
        {
            var item = new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m);
            item.Id = id;
            return Ok(item);
        }
    }
}
