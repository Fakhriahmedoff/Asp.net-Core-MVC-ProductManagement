using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUi.Models
{
    public class ShippingDetail
    {
        //  [Required(ErrorMessage = " Firstname is Required")]
        public string FirstName { get; set; }
        // [Required]
        public string LastName { get; set; }
        // [Required]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //   [Required]
        public string City { get; set; }
        //[Required]
        //[MinLength(10, ErrorMessage ="MinLength must be above than 10")]
        public string Address { get; set; }
        //  [Required]
        //[Range(18,80)]
        public int Age { get; set; }
    }
}
