using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Excel002.Models
{
    public class InvoiceItem
    {
        public Int32 Id { get; set; }

 
        public Int32 CityId { get; set; }
        public City city { get; set; }

  
        public Int32 CustomerId { get; set; }
        public Customer customer { get; set; }

   
        public Int32 ProductId { get; set; }
        public Product product { get; set; }
        public float Price { get; set; }

        
    }
}
