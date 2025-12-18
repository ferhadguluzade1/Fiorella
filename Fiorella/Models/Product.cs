using Fiorella.Models.Base;

namespace Fiorella.Models
{
    public class Product : BaseEntity
    {
       
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<Image> Images { get; set; }
        public List<Category> Categories { get; set; }
        public List<Tag> Tags { get; set; }

        public Product(string name, string description, decimal price, List<Image> images, List<Category> categories,List<Tag> tags )
        {
            Name = name;
            Description = description;
            Price = price;
            Images = images;
            Categories = categories;
            Tags = tags;
            
        }

        public static implicit operator List<object>(Product v)
        {
            throw new NotImplementedException();
        }
    }
}
