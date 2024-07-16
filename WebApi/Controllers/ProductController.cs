using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        { 
            _context = context;
        }

        public IActionResult Post(Product product)
        { 
          _context.Products.Add(product);
            _context.SaveChanges();
            return Ok();     // 200
        }

    }
}
