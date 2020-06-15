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
            return Task.FromResult<ActionResult<IEnumerable<Cheese>>>(Ok(Cheeses.All));
        }
    }
}