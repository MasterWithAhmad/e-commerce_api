using System.ComponentModel.DataAnnotations;
namespace ECommerceAPI.Models
{

    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [StringLength(200)]
        public string? Address { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }

}