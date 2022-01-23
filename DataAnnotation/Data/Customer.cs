using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotation.Data
{
    public class Customer
    {

        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }
        [Required]
        public List<Address> Address { get; set; }


    }
}
