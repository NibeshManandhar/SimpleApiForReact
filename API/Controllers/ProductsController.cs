using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContex _contex;

        public ProductsController(StoreContex contex)
        {
            _contex = contex;

        }


        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return await _contex.Products.ToListAsync();

        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await _contex.Products.FindAsync(id);
        }

    }
}