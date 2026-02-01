using Microsoft.AspNetCore.Mvc;
using Sprint_0_Group_4.Data;

namespace Sprint_0_Group_4.Controllers
{
    public class UsersController : Controller
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var users = _context.AppUser.ToList();

            return View(users);
        }
    }
}
