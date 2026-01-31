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

            //var users = new List<AppUser>
            //{
                //new AppUser { AppUserId = 1, Username="jsmith", Email="jsmith@email.com", Firstname="John", Lastname="Smith" },
                //new AppUser { AppUserId = 2, Username="ajones", Email="ajones@email.com", Firstname="Alice", Lastname="Jones" }
            //};

            //return View(users);
        }
    }
}
