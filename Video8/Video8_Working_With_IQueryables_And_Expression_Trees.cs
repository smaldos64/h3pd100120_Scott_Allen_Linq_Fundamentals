using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Scott_Allen_Linq_Fundamentals.Video8
{
    class Video8_Working_With_IQueryables_And_Expression_Trees
    {
        public static void Video8_Working_With_IQueryables_And_Expression_Trees_Start()
        {
            // Når man arbejder op imod Entity Framework benytter man sig af (kan man benytte sig af) 
            // et nýt interface => IQueryable. Derfor kan man nu benytte sig af 4 forskellige
            // versioner af Where metoden (når man ikke arbejder op imod Entity Framework
            // kan man kun benytte sig af 2 versioner af Where metoden. Og begge disse 
            // versioner returnerer en IEnumerable !!!).
            // De 2 af versionerne returnerer en IEnumerable som tidligere når vi ikke
            // arbejder op imod Entity Framework. De 2 sidste af versionerne returnerer en
            // IQueryable. 
            // C# compileren tager pr. default en af versionerne, der returnerer en IQueryable !!!

            // IEnumerable skal udføre kode i memory.
            // IQuerybale behøver ikke udføre kode i mmemory !!!

            // Ved IQueryable er det den overførte Expression, der afgør hvordan Linq udtrykket
            // udføres !!!

            Console.WriteLine("");
            Console.WriteLine("Video8_Working_With_IQueryables_And_Expression_Trees");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("");

            Func<int, int> square = x => x * x;
            Func<int, int, int> add = (x, y) => x + y;
            Expression<Func<int, int, int>> addExpression = (x, y) => x + y; 
            // Kræver namespace System.Linq.Expression

            var result = add(3, 5);
            Console.WriteLine(result);
            Console.WriteLine(add);

            Console.WriteLine("");
            Console.WriteLine(addExpression);
            //result = addExpression.Body(4, 8);
        }
    }
}
