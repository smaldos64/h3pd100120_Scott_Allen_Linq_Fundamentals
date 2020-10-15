using Scott_Allen_Linq_Fundamentals.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Scott_Allen_Linq_Fundamentals.Video8
{
    class Video8_5_Working_With_IQueryables_And_Expression_Trees
    {
        public static void Video8_5_Working_With_IQueryables_And_Expression_Trees_Start()
        {
            var db = new DatabaseContext();

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

            // IQuerybale behøver ikke udføre kode i memory !!!
            // Ved IQueryable er det den overførte Expression, der afgør hvordan Linq udtrykket
            // udføres !!!

            // Det vil sige, at modsat et udtryk der returnerer IEnumerable, returneres der nu
            // med IQuerable et Expression der wrapper en Func af Cars og bool : 
            // Expression<Func<Car,bool>>. Ved IEnumerable returneres der en Func af Cars og bool. 

            Console.WriteLine("");
            Console.WriteLine("Video8_5_Working_With_IQueryables_And_Expression_Trees");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("");

            Func<int, int> square = x => x * x;
            Func<int, int, int> add = (x, y) => x + y;
            Expression<Func<int, int, int>> addExpression = (x, y) => x + y; 
            // Når vi wrapper et FUnc udtryk med Expression har vi den situation der opstår,
            // når vi anvender Where metoden på en IQueryable, hvor Where jo i henhold til
            // ovennævnte tager imod et Expression af Func<Car,bool>.
            // Kræver namespace System.Linq.Expression

            //var result = add(3, 5);
            Console.WriteLine(add);
            Console.WriteLine(add(3, 5));
            Console.WriteLine(add.Invoke(3, 5));
            //Console.WriteLine(result);
            
            var addExpressionCompile = addExpression.Compile();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(addExpression);
            Console.WriteLine(addExpressionCompile);
            Console.WriteLine(addExpressionCompile.Invoke(6, 8));
            Console.WriteLine(addExpressionCompile(6, 8));
            Console.WriteLine(addExpression.Compile()(6, 8));
            Console.WriteLine(addExpression.Compile().Invoke(6, 8));
            //result = addExpression.Body(4, 8);
        }
    }
}
