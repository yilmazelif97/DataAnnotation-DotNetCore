using System.ComponentModel.DataAnnotations;

namespace DataAnnotation.Data
{
    public class Employee
    {

        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(11)]
        [Required]
        public string PhoneNumber { get; set; }

    }
}
