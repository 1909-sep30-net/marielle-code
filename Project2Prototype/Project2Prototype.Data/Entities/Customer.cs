using System.ComponentModel.DataAnnotations;

namespace Project2Prototype.Data.Entities
{
    public class Customer
    {
        [Key]
        public string PhoneNumber { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}