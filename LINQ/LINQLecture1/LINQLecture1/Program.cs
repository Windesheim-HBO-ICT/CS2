using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLecture1
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new[] { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };

            // ...
            
            Employee[] employees = {
                 new Employee( "Jason", "Red", 5000M ),
                 new Employee( "Ashley", "Green", 7600M ),
                 new Employee( "Matthew", "Indigo", 3587.5M ),
                 new Employee( "James", "Indigo", 4700.77M ),
                 new Employee( "Luke", "Indigo", 6200M ),
                 new Employee( "Jason", "Blue", 3200M ),
                 new Employee( "Wendy", "Brown", 4236.4M )
            };

            // ...

            var items = new List<string>
            {
                "aQua", "RusT", "yElLow", "rEd"
            };
        }
    }
}
