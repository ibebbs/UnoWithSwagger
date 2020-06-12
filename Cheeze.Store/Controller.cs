using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Cheeze.Store
{
    [Route("api/store")]
    public class Controller : Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Cheese>), (int)HttpStatusCode.OK)]
        public Task<ActionResult<IEnumerable<Cheese>>> Get()
        {
            var result = new[]
            {
                new Cheese
                {
                    Id = Guid.Parse("1468841a-5fbe-41c5-83b3-ab136b7ae70c"),
                    Name = "Colston Bassett Stilton",
                    Description = "An intensely rich and creamy Stilton , with a deep, lingering, complex flavour.",
                    Uri = new Uri("https://www.finecheese.co.uk/our-cheeses/colston-bassett-stilton"),
                    ImageUri = new Uri("https://www.finecheese.co.uk/media/catalog/product/cache/1/image/500x500/9df78eab33525d08d6e5fb8d27136e95/c/b/cb_stilton_b__8.jpg")
                },
                new Cheese
                {
                    Id = Guid.Parse("daad6d7f-3003-4d65-a194-88d0ad15f3da"),
                    Name = "Pitchfork Somerset Cheddar",
                    Description = "A brand new Artisan Somerset Cheddar made by Todd and Maugan Trethowan, just seven miles from Cheddar Gorge. Moist and succulent in texture, it is full-flavoured with a hint of tropical fruit.",
                    Uri = new Uri("https://www.finecheese.co.uk/our-cheeses/pitchfork"),
                    ImageUri = new Uri("https://www.finecheese.co.uk/media/catalog/product/cache/1/image/500x500/9df78eab33525d08d6e5fb8d27136e95/p/i/pitchfork-by-fcc-june-20-1_b_.jpg")
                }
            };

            return Task.FromResult<ActionResult<IEnumerable<Cheese>>>(Ok(result));
        }
    }
}