using Fiorella.Models.Base;
namespace Fiorella.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }

        public Category(string name, List<Product> products)
        {
            Name = name;
            Products = products;
            
        }
    }
}
