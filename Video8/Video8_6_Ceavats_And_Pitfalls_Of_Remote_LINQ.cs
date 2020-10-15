using Scott_Allen_Linq_Fundamentals.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scott_Allen_Linq_Fundamentals.Video8
{
    public class Video8_6_Ceavats_And_Pitfalls_Of_Remote_LINQ
    {
        public static void Video8_6_Ceavats_And_Pitfalls_Of_Remote_LINQ_Start()
        {
            Console.WriteLine("");
            Console.WriteLine("Video8_6_Ceavats_And_Pitfalls_Of_Remote_LINQ");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("");

            var db = new DatabaseContext(UseDatabaseLogging : true);
            //db.UseDatabaseLogging = true;
            // Begge linjer koder herover vil enable Database logging for vores nuværende 
            // objekt af vores DatabaseContext (db). Det er selvfølgelig 
            // kun nødvendig at bruge den ene af kode linjerne for at enable 
            // Database logging for vores db Objekt.

            // Alle LINQ operatorer tidligere gennemgået : GruopBy, OrderBy, Join Where
            // og så videre er også tilgængelige, når vi bruger Enity Framework.

            // Når man bruger Entity Framework, skal man altid være opmærksom på, om 
            // man arbejder op imod IQueryable eller IEnumerable !!!

            // Alle operatorerne i udtrykket herunder arbejder som IQueryable.
            var queryMethodSyntax_IQueryable = db.Cars.
                OrderByDescending(c => c.Combined).
                ThenBy(c => c.Name).
                Take(10);

            foreach (var car in queryMethodSyntax_IQueryable)
            {
                Console.WriteLine($"{car.Name} : {car.Combined}");
            }
            Console.WriteLine("");

            //db.UseDatabaseLogging = true;
            // Kodelinjen herover vil disable Database logging for vores Database objekt (db).

            var queryMethodSyntax_IEnumerable = db.Cars.
                OrderByDescending(c => c.Combined).
                ThenBy(c => c.Name).
                ToList().
                Take(10);

            foreach (var car in queryMethodSyntax_IEnumerable)
            {
                Console.WriteLine($"{car.Name} : {car.Combined}");
            }
            Console.WriteLine("");

            var queryMethodSyntax_IQueryable_Then_IEnumerable = db.Cars.
                OrderByDescending(c => c.Combined).
                ThenBy(c => c.Name).
                Take(10).
                ToList();

            // Entity Framework udtrykkene her bruger stadigvæk Third Execution rule.

            foreach (var car in queryMethodSyntax_IQueryable_Then_IEnumerable)
            {
                Console.WriteLine($"{car.Name} : {car.Combined}");
            }
            Console.WriteLine("");
            Console.WriteLine(" ");

            Console.WriteLine($"queryMethodSyntax_IEnumerable Count : {queryMethodSyntax_IEnumerable.Count()}");
            Console.WriteLine(" ");
            Console.WriteLine($"queryMethodSyntax_IQueryable_Then_IEnumerable Count : {queryMethodSyntax_IQueryable_Then_IEnumerable.Count()}");
            Console.WriteLine(" ");
            Console.WriteLine($"queryMethodSyntax_IQueryable Count : {queryMethodSyntax_IQueryable.Count()}");

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            var queryMethodSyntax_IQueryable_Then_IEnumerable_Plus_Select = db.Cars.
               OrderByDescending(c => c.Combined).
               ThenBy(c => c.Name).
               Take(10).
               Select(c => new { Name = c.Name.ToUpper() }).
               ToList();

            foreach (var car in queryMethodSyntax_IQueryable_Then_IEnumerable_Plus_Select)
            {
                Console.WriteLine($"{car.Name}");
            }
            Console.WriteLine("");
            Console.WriteLine(" ");

            // Eksemplet herunder viser, at der er begrænsninger på, hvad LINQ til Entity Framework
            // kan håndtere !!!

            //var queryMethodSyntax_IQueryable_Then_IEnumerable_Plus_Select_Split = db.Cars.
            //   OrderByDescending(c => c.Combined).
            //   ThenBy(c => c.Name).
            //   Take(10).
            //   Select(c => new { Name = c.Name.Split(' ') }).
            //   ToList();

            //foreach (var car in queryMethodSyntax_IQueryable_Then_IEnumerable_Plus_Select)
            //{
            //    Console.WriteLine($"{car.Name}");
            //}
            //Console.WriteLine("");
            //Console.WriteLine(" ");

            var queryMethodSyntax_IQueryable_Then_IEnumerable_Plus_Select_Split = db.Cars.
               OrderByDescending(c => c.Combined).
               ThenBy(c => c.Name).
               Take(10).
               ToList().
               Select(c => new { Name = c.Name.Split(' ') });

            foreach (var car in queryMethodSyntax_IQueryable_Then_IEnumerable_Plus_Select)
            {
                Console.WriteLine($"{car.Name}");
            }
            Console.WriteLine("");
            Console.WriteLine(" ");
        }
    }
}
