using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Excel002.Models
{
    public class Customer
    {
        public Int32 Id { get; set; }

 
        public String Name_Family { get; set; }

        public IEnumerable<InvoiceItem> invoiceItems;
    }
}
