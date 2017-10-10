using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLecture1
{

    // Fig. 9.3: Employee.cs
    public class Employee
    {
        private decimal monthlySalaryValue;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Employee(string first, string last, decimal salary)
        {
            FirstName = first;
            LastName = last;
            MonthlySalary = salary;
        }

        public decimal MonthlySalary
        {
            get
            {
                return monthlySalaryValue;
            } // end get
            set
            {
                if (value >= 0M) // if salary is non-negative
                {
                    monthlySalaryValue = value;
                }
            }
        }
        public override string ToString()
        {
            return string.Format("{0,-10} {1,-10} {2,10:C}",
               FirstName, LastName, MonthlySalary);
        }
    }

    /**************************************************************************
     * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
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

}
