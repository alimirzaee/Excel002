using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Excel002.Models
{
    public class AddInvoiceModel
    {
        [Required]
        [Range(1, 100000000, ErrorMessage ="Please Select City ")]
        public int CityId { get; set; }
        public String CityName { get; set; }


        [Required]
        [Range(1, 100000000, ErrorMessage = "Please select the Customer")]
        public int CustomerId { get; set; }
        public String CustomerName { get; set; }

        [Required]
        [Range(1, 100000000, ErrorMessage ="Please select the Product")]
        public int ProductId { get; set; }
        public String ProductName { get; set; }

        [Required]
        [MaxLength(3,ErrorMessage ="Code is Not Valid")]
        public String ProductCode { get; set; }

        [Required]
        [Range(1,100000000, ErrorMessage ="Entered Price is not in Range")]
        public float Price { get; set; }



    }
}
