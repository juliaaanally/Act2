using System.ComponentModel.DataAnnotations;

namespace Act2.Models
{
    public class RecentlySeen
    {
        public int Id { get; set; }
        public decimal Value { get; set; }

        [Required]
        public string? Description { get; set; }
    }
}
