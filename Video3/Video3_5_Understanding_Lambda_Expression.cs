using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Scott_Allen_Linq_Fundamentals.Core.Domain;

namespace Scott_Allen_Linq_Fundamentals.Video3
{
    public class Video3_5_Understanding_Lambda_Expression
    {
        public static void Video3_5_Understanding_Lambda_Expression_Start()
        {
            Console.WriteLine("");
            Console.WriteLine("Video3_5_Understanding_Lambda_Expression");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("");

            // Selvom Lambda Expressions mange gange hører sammen med Linq kode, kan 
            // Lambda Expression også sagtens fungere på "egen hånd".

            IEnumerable<Employee> developers_IEnumerable = new List<Employee>()
            {
                new Employee {Id = 4, Name = "Scott"},
                new Employee {Id = 5, Name = "Chris"},
                new Employee {Id = 6, Name = "Severin"},
            };

            // Metode 1 => Named Method
            foreach (var employee in developers_IEnumerable.Where(NameStartsWithS))
            {
                Console.WriteLine("Employee Name : {0}", employee.Name);
            }

            Console.WriteLine("");

            // Metode 2 => Anonymous Method
            foreach (var employee in developers_IEnumerable.Where(
                delegate (Employee employee)
                {
                    return employee.Name.StartsWith("S");
                })
            )
            {
                Console.WriteLine("Employee Name : {0}", employee.Name);
            }

            Console.WriteLine("");

            // Metode 3 -> Lambda Expression -Énbogstavs navngivning
            foreach (var employee in developers_IEnumerable.Where(
                e => e.Name.StartsWith("S")
                )
            )
            {
                Console.WriteLine("Employee Name : {0}", employee.Name);
            }

            Console.WriteLine("");

            // Metode 3 => Ny => Lambda Expression - Sigende navngivning
            foreach (var employee in developers_IEnumerable.Where(
                employee => employee.Name.StartsWith("S")
                )
            )
            {
                Console.WriteLine("Employee Name : {0}", employee.Name);
            }

            Console.WriteLine("");
        }

        private static bool NameStartsWithS(Employee employee)
        {
            return employee.Name.StartsWith("S");
        }
    }
}
