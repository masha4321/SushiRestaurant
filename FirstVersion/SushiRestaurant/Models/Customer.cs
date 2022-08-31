using System.ComponentModel.DataAnnotations;

namespace SushiRestaurant.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
