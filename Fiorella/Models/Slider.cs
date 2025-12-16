using Fiorella.Models.Base;

namespace Fiorella.Models
{
    public class Slider : BaseEntity
    {
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
