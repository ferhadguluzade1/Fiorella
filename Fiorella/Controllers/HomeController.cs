using Fiorella.DAL;
using Fiorella.Models;
using Fiorella.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace Fiorella.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel();

            Product product = new Product()
            {
                Id = 1,
                Name = "",
                Description = "",
                Price = 0
            };

            Product product1 = new Product()
            {
                Id = 0,
                Name = "",
                Description = "",
                Price = 0
            };

            Slider slider = new Slider()
            {
                ImgUrl = "",
                Title = "",
                Content = ""
            };

            Slider slider1 = new Slider()
            {
                ImgUrl = "",
                Title = "",
                Content = ""
            };


            List<Product> products = new List<Product>();
            products.Add(product);
            products.Add(product1);

            List<Slider> sliders = new List<Slider>();
            sliders.Add(slider);
            sliders.Add(slider1);

            homeViewModel.Products.Add(product);
            homeViewModel.Products.Add(product1);

            homeViewModel.Sliders.Add(slider);
            homeViewModel.Sliders.Add(slider1);
            return View();
        }



        AppDbContext _db;

        public HomeController()
        {
            
        }
    }
}
