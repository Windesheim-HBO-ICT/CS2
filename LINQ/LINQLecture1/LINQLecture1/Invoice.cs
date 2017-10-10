using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLecture1
{
    // Exercise 9.3 Solution: Invoice.cs
    public class Invoice
    {
        private int quantityValue;
        private decimal priceValue;
        
        public int PartNumber { get; set; }
        
        public string PartDescription { get; set; }
        
        public Invoice(int part, string description,
           int count, decimal pricePerItem)
        {
            PartNumber = part;
            PartDescription = description;
            Quantity = count;
            Price = pricePerItem;
        }
        
        public int Quantity
        {
            get
            {
                return quantityValue;
            }
            set
            {
                if (value > 0) // determine whether quantity is positive
                {
                    quantityValue = value; 
                }
            }
        }

        public decimal Price
        {
            get
            {
                return priceValue;
            }
            set
            {
                if (value >= 0M) // determine whether price is non-negative
                {
                    priceValue = value; 
                }
            }
        }
        
        // left justify each field, and give large enough spaces so
        // all the columns line up
        public override string ToString() =>
           $"{PartNumber,-5} {PartDescription,-20} {Quantity,-5} {Price,6:C}";
    }
}

/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
