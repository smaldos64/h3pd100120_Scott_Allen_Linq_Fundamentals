using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Scott_Allen_Linq_Fundamentals.Core.Domain;

namespace Scott_Allen_Linq_Fundamentals.Video3
{
    public class Video3_7_Query_Syntax_Versus_Method_Syntax
    {
        public static void Video3_7_Query_Syntax_Versus_Method_Syntax_Start()
        {
            Console.WriteLine("");
            Console.WriteLine("Video3_7_Query_Syntax_Versus_Method_Syntax");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("");

            IEnumerable<Employee> developers_IEnumerable = new List<Employee>()
            {
                new Employee {Id = 4, Name = "Scott"},
                new Employee {Id = 5, Name = "Chris"},
                new Employee {Id = 6, Name = "Severin"},
            };

            // video 3 => Query Syntax versus Method Syntax
            // De 2 første Scott_Allen_Linq_Fundamentals herunder (query og query1) er bygget op omkring Method Syntax.
            // Method Syntax har nogle flere muligheder i forhold til Query Syntax. Så man kan ende ud i,
            // at man skal bruge Method Syntax. Det kan være ved operationer som Count, Take og Skip.
            var queryMethodSyntax = developers_IEnumerable.Where(e => e.Name.Length > 6).OrderBy(e => e.Name);

            var queryMethodSyntax1 = developers_IEnumerable.Where(e => e.Name.Length > 6).OrderBy(e => e.Name).Select(e => e);

            // Den viste query herunder er bugget op omkring Query Syntax.
            var queryQuerySyntax = from employee in developers_IEnumerable
                                   where employee.Name.Length > 6
                                    orderby employee.Name
                                    select employee;

            var queryQuerySyntax1 = from employee in developers_IEnumerable
                                    where employee.Name.Length > 6
                                    orderby employee.Name descending
                                    select employee;

            var queryMethodSyntax2 = developers_IEnumerable.Where(e => e.Name.Length > 6).OrderByDescending(e => e.Name);

            foreach (var employee in queryQuerySyntax)
            {
                Console.WriteLine("Employee Name : {0}", employee.Name);
            }
        }
    }
}
