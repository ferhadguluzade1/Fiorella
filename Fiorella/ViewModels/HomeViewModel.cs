using Fiorella.Models;

namespace Fiorella.ViewModels
{
    public class HomeViewModel
    {
        public List<Product> Products { get; set; }
        public List<Slider> Sliders { get; set; }

        public Product Product { get; set; } 
        //public HomeViewModel()
        //{
        //    Products = new List<Product>();
        //    Sliders = new List<Slider>();
        //}
    }
}
