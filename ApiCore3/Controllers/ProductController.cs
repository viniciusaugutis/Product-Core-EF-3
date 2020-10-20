using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCore3.Data;
using ApiCore3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCore3.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get([FromServices] DataContext context)
        {
            var products = await context.Products.Include(x => x.Category).AsNoTracking().ToListAsync();

            return Ok(products);
        }
    }
}
