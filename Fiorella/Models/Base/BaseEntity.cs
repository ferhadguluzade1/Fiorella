namespace Fiorella.Models.Base
{
    public class BaseEntity
    {
        public int Id { get; set; }
        //public bool IsDeleted { get; set; } //Soft Delete

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
    
    }
}
