using System.ComponentModel.DataAnnotations;

namespace Project2Prototype.Data.Entities
{
    public class Creator
    {
        [Key]
        public int PhoneNumber { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}