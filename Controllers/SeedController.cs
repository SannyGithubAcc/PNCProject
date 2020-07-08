using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PNCDemoWebApi.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PNCDemoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SeedController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/seed
        [HttpGet("getSupperliers")]
        public async Task<ActionResult<IEnumerable<Supplier>>> GetSupperliers()
        {
            return await _context.Suppliers.ToListAsync();
        }
        [HttpGet("getProducts")]


        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }
        [HttpGet("getRatings")]
        public async Task<ActionResult<IEnumerable<Rating>>> GetRatings()
        {
            return await _context.Ratings.ToListAsync();
        }

    }
}
