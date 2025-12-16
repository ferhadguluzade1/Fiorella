using Fiorella.Models.Base;

namespace Fiorella.Models
{
    public class Image : BaseEntity
    {
        public string Url { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public bool IsPrimary { get; set; } = false;
        
    }
}
