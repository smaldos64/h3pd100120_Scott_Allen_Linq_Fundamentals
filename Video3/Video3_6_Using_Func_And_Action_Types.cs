using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Scott_Allen_Linq_Fundamentals.Core.Domain;

namespace Scott_Allen_Linq_Fundamentals.Video3
{
    public class Video3_6_Using_Func_And_Action_Types
    {
        public static void Video_3_6_Using_Func_And_Action_Types_Start()
        {
            Console.WriteLine("");
            Console.WriteLine("Video_3_6_Using_Func_And_Action_Types");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("");

            IEnumerable<Employee> developers_IEnumerable = new List<Employee>()
            {
                new Employee {Id = 4, Name = "Scott_IEnumerable"},
                new Employee {Id = 5, Name = "Chris_IEnumerable"},
                new Employee {Id = 6, Name = "Severin_IEnumerable"},
            };

            // Video 3 => Using Func and Action Types
            // Named Methods
            Func<int, int> fNamedExpressionSquare = Square;

            Console.WriteLine("(Named Method) Square of {0} is {1}", 3, fNamedExpressionSquare(3));

            Func<int, int> fLambdaExpressionSquare = x => x * x;

            Console.WriteLine("(Lambda Expression) Square of {0} is {1}", 4, fLambdaExpressionSquare(4));

            Func<int, int, int> fLambdaExpressionAdd = (x, y) => x + y;

            Console.WriteLine("(Lambda Expression) Square of {0}+{1} is {2}", 3, 5, fLambdaExpressionSquare(fLambdaExpressionAdd(3, 5)));

            Func<int, int, int> fLambdaExpressionSubtract = (int x, int y) =>
            {
                int temp = x - y;
                return temp;
            };

            Action<int> MyLambdaExpressionWrite = x => Console.WriteLine(x);
            // Modsat Func returnerer Action ikke noget.

            MyLambdaExpressionWrite(fLambdaExpressionSquare(fLambdaExpressionAdd(3, 5)));

            Console.WriteLine("");

            foreach (var employee in developers_IEnumerable.Where(
                e => e.Name.StartsWith("S")
                )
                .OrderByDescending(e => e.Name)
            )
            {
                Console.WriteLine("Employee Name : {0}", employee.Name);
            }

            Console.WriteLine("");
        }

        private static int Square(int arg)
        {
            return arg * arg;
        }
    }
}
