using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Fiorella.DAL;
using Fiorella.Models;

namespace Fiorella.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

        }



        AppDbContext _db;

        public HomeController()
        {
            
        }
    }
}
