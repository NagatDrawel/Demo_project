using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialDemo
{
    class Invoice
    {
        public int PartNumber { get; set; }
        public string PartDescription { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Invoice(int PartNumber, string PartDescription, int Quantity, decimal Price)
        {
            this.PartNumber = PartNumber;
            this.PartDescription = PartDescription;
            this.Quantity = Quantity;
            this.Price = Price;
        }
        
        public String ToString()
        {
            return $"{PartNumber,-5} {PartDescription, -20} {Quantity, -5} {Price,6:C}";
        }
    }
}
