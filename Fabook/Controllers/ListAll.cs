using Fabook.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fabook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListAll : ControllerBase
    {
        private readonly Fabook_T_NContext _context;

        public ListAll(Fabook_T_NContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IActionResult Get()
        {
            var ls = _context.Users.ToList();
            return Ok(ls);
        }
    }
}
