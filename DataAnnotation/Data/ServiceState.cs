using System;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotation.Data
{
    public class ServiceState
    {

        public int Id { get; set; }

        [Required]
        public string SerialNumber { get; set; }
        [Required]
        public string Warranty { get; set; }
        public DateTime OperationDate { get; set; }
        public string TechnicalNote { get; set; }

        [Required]
        public Employee Employee { get; set; }
        [Required]
        public Status Status { get; set; }
        [Required]

        public ServiceRequest ServiceRequest { get; set; }
        public int ListPrice { get; set; }


    }
}