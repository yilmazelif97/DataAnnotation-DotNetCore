using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotation.Data
{
    public class ServiceRequest
    {

        public int Id { get; set; }
        [Required]
        public string TrackingNumber { get; set; }
        public string Note { get; set; }
        [Required]
        public Address CustomerAddress { get; set; }
        [Required]
        public Customer Custoemr { get; set; }
        [Required]
        public DateTime ServiceDate { get; set; }
        [Required]

        public List<ServiceState> ServiceState { get; set; }
    }
}
