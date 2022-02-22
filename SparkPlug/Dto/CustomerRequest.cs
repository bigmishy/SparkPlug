using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SparkPlug.Dto
{
    public class CustomerRequest
    {
        [Required]
        public String CustomerName { get; set; }
        [Required, EmailAddress]
        public String CustomerEmail { get; set; }
        [Required]
        public String CustomerMessage { get; set; }

    }
}
