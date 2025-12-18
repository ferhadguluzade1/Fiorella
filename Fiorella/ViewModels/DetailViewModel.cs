using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Fiorella.Models;

namespace Fiorella.ViewModels
{
    public class DetailViewModel
    {
        
        public List<Product> Products { get; set; }

        public DetailViewModel(List<Product> products)
        {
            Products = products;
        }

        public static implicit operator DetailViewModel(DetailViewModel v)
        {
            throw new NotImplementedException();
        }
    }
}
