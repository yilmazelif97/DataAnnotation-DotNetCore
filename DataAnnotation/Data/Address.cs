using System.ComponentModel.DataAnnotations;

namespace DataAnnotation.Data
{
    public class Address
    {

        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Provience { get; set; }

        [MaxLength(150)]
        [Required]
        public string Street { get; set; }

        [MaxLength(50)]
        [Required]
        public string City { get; set; }
        public bool isDefault { get; set; } = false;


    }
}
