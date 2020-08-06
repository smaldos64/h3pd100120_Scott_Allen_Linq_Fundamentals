using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Scott_Allen_Linq_Fundamentals.Core.Domain;
//using Scott_Allen_Linq_Fundamentals.Persistence;
using Scott_Allen_Linq_Fundamentals.Extensions;


namespace Scott_Allen_Linq_Fundamentals.Video3
{
    public class NotUsingLinq
    {
        // Video 3 => The Power of IEnumerable

        //protected UnitOfWork unitOfWork;
        public NotUsingLinq()
        {
            //unitOfWork = new UnitOfWork(new PlutoContext());
        }
        public void ShowAuthorsNotUsingLinq()
        {
            Console.WriteLine("NOT USING LINQ");
            Console.WriteLine("");

            Employee[] developers = new Employee[]
            {
                new Employee {Id = 1, Name = "Scott"},
                new Employee {Id = 2, Name = "Chris"}
            };

            PrintOutItems(developers, "Gemt i Array");

            List<Employee> sales = new List<Employee>()
            {
                new Employee {Id = 3, Name = "Alex"}
            };

            PrintOutItems(sales, "Gemt i List");

            IEnumerable<Employee> developers_IEnumerable = new Employee[]
            {
                new Employee {Id = 4, Name = "Scott_IEnumerable"},
                new Employee {Id = 5, Name = "Chris_IEnumerable"}
            };

            PrintOutItems(developers_IEnumerable, "Gemt i IEnumerable => Array");

            IEnumerable<Employee> sales_IEnumerable = new List<Employee>()
            {
                new Employee {Id = 6, Name = "Alex_IEnumerable"}
            };

            PrintOutItems(sales_IEnumerable, "Gemt i Ienumerable => List");

            // Både Array og List implementerer GetEnumerator !!! , da
            // både Array og List implementerer Interface IEnumerable<T>
            // Man kan se dette ved at stille cursoren på List eller Array og 
            // trykke på <F12>.
        }

        private void PrintOutItems(IEnumerable<Employee> Items, string LeadingText)
        {
            Console.WriteLine("");
            Console.WriteLine(LeadingText);
            Console.WriteLine("");

            IEnumerator<Employee> employyIEnumerable = Items.GetEnumerator();
            while (employyIEnumerable.MoveNext())
            {
                Console.WriteLine("Author : {0}", employyIEnumerable.Current.Name);
            }
            
            Console.WriteLine("");
        }
    }
}
