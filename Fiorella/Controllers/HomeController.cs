using Fiorella.DAL;
using Fiorella.Models;
using Fiorella.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Fiorella.Controllers
{
    public class HomeController : Controller
    {

        public readonly AppDbContext _db;
        public HomeController(AppDbContext context)
        {
            _db = context;
        }
        public HomeController()
        {
            
        }

        public IActionResult Index()
        {

            //           Slider slider1 = new Slider(
            //               "Spring Collection",                 // name
            //               "1-1-524x617.png",                    // imgUrl
            //               "Spring Collection",                 // title
            //               "Discover our new spring collection with vibrant colors and fresh styles." // content
            //);

            //           Slider slider2 = new Slider(
            //               "Summer Sale",
            //               "1-4-770x300.jpg",
            //               "Summer Sale",
            //               "Enjoy the summer vibes with our exclusive summer sale offers."
            //           );

            //           Slider slider3 = new Slider(
            //               "Autumn Arrivals",
            //               "1-1-1820x443.jpg",
            //               "Autumn Arrivals",
            //               "Check out the latest autumn arrivals to refresh your wardrobe."
            //           );



            //           List<Slider> sliders = new List<Slider>
            //                 {
            //                       slider1,
            //                       slider2,
            //                       slider3
            //                 };

            //           List<Product> products = _db.Products
            //           .Include(p => p.Images)
            //           .ToList();

            //           HomeViewModel homeVM = new HomeViewModel
            //           {
            //               Products = products,
            //               Sliders = sliders
            //           };

            var products = _db.Products.ToList();
            var sliders = _db.Sliders.ToList();
            HomeViewModel homeVM = new HomeViewModel
            {
                Products = products,
                Sliders = sliders
            };

            return View(homeVM);
        }
        public IActionResult Detail(/*int id*/) /*Product product*/
        {
            //var products = _db.Products
            //.Include(p => p.Images)
            //.Include(p => p.Name)
            //.Include(p => p.Categories)
            //.Include(p => p.Tags)
            //.FirstOrDefault(p => p.Id == id);

            //var categoryIds = product.Categories.Select(c => c.Id).ToList();

            //var relatedProducts = _db.Products
            //    .Include(p => p.Images)
            //    .Include(p => p.Categories)
            //    .Where(p => p.Categories.Any(c => categoryIds.Contains(c.Id)) && p.Id != product.Id)
            //    .Distinct()
            //    .Take(2)
            //    .ToList();

            //DetailViewModel detailVM = new DetailViewModel(List<Product> products)
            //{



            //};

            //HomeViewModel homeVM = new HomeViewModel
            //{
            //    Products = _db.Products.ToList(),
            //    Product = _db.Products.Find(id)
            //};


            return View(/*detailVM*/);
        }

    }
}

