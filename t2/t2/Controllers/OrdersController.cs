using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using t2.Data;

namespace t2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public OrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

    }
}
