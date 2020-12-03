using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialDemo
{
    partial class Lab_7
    {
        static void Method_1()
        {

            Invoice[] Invoices = new Invoice[]{
            new Invoice(83, "Electric sander", 7, 57.98m),
            new Invoice(24, "Power saw", 18, 99.99m),
            new Invoice(7, "Sledge hammer", 11, 21.50m),
            new Invoice(77, "Hammer", 76, 11.99m),
            new Invoice(39, "Lawn mower", 3, 79.50m),
            new Invoice(24, "Screwdriver", 106, 6.99m),
            new Invoice(56, "Jig saw", 21, 11.00m),
            new Invoice(3, "Wrench", 34, 7.50m)
            };

            Console.WriteLine("Part Description: ");
            //A:
            var PartDescription =
                from invoice in Invoices
                orderby invoice.PartDescription
                select invoice;
            foreach (var invoice in PartDescription)
            {
                Console.WriteLine(invoice.ToString());
            }

            Console.WriteLine("\nPrices: ");
            //B:
            var Prices =
                from invoice in Invoices
                orderby invoice.Price
                select invoice;
            foreach (var invoice in Prices)
            {
                Console.WriteLine(invoice.ToString());
            }
              //D: 
            Console.WriteLine("\nPart Description and the value of the Invoice (Quantity * Price)");
            var PartandValue =
                from invoice in Invoices
                let InvoiceTotal = invoice.Quantity * invoice.Price
                orderby InvoiceTotal
                select new { invoice.PartDescription, InvoiceTotal };

            foreach (var invoice in PartandValue)
            {
                Console.WriteLine(invoice);
            }

            //E:
            Console.WriteLine("\nInvoice Totals in the range of $200 and $500");
            var priceRange =
                from invoice in Invoices
                let InvoiceTotal = invoice.Quantity * invoice.Price
                where InvoiceTotal > 200 && InvoiceTotal < 500
                select invoice;
            foreach (var invoice in priceRange)
            {
                Console.WriteLine(invoice.ToString());
            }
        }
    }
}
