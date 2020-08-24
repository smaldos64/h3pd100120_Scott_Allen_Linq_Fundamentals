using Scott_Allen_Linq_Fundamentals.Context;
using Scott_Allen_Linq_Fundamentals.Core.Domain;
using Scott_Allen_Linq_Fundamentals.Extensions;
using Scott_Allen_Linq_Fundamentals.Files;
using Scott_Allen_Linq_Fundamentals.Statistics;
using System;
using System.Linq;

namespace Scott_Allen_Linq_Fundamentals.Video8
{
    public class Video8_An_Advanced_LINQ_Query
    {
        public static void Video8_An_Advanced_LINQ_Query_Start()
        {
            Console.WriteLine("");
            Console.WriteLine("Video8_An_Advanced_LINQ_Query");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("");

            //var cars = ProcessDataFromFiles.ProcessCar("fuel.csv");
            //var manufacturers = ProcessDataFromFiles.ProcessManufacturers("manufacturers.csv");

            var db = new DatabaseContext(UseDatabaseLogging: true);
            var cars_DB = db.Cars.ToList();
            //Enumerable<Car> cars1_DB = db.Cars as Enumerable;
                
            Console.WriteLine("Query Syntax Group by fra Database");
            Console.WriteLine(" ");

            var queryQuerySyntax_DB = from car in cars_DB
                                      group car by car.Manufacturer into manufacturer
                                      orderby manufacturer.Key
                                      select new
                                      {
                                          Name = manufacturer.Key,
                                          Cars = (from car in manufacturer
                                                  orderby car.Combined descending
                                                  select car).Take(2)
                                      };

            foreach (var manufacturer in queryQuerySyntax_DB)
            {
                Console.WriteLine(manufacturer.Name);
                foreach (var car in manufacturer.Cars)
                {
                    Console.WriteLine($"\t{car.Name} : {car.Combined}");
                }
            }
            Console.WriteLine(" ");

            Console.WriteLine("Method Syntax Group by fra Database");
            Console.WriteLine(" ");

            var queryMethodSyntax_DB = cars_DB.GroupBy(c => c.Manufacturer)
                .OrderBy(m => m.Key)
                .Select(g => new
                {
                    Name = g.Key,
                    Cars = g.OrderByDescending(c => c.Combined).Take(2)
                });

            foreach (var manufacturer in queryMethodSyntax_DB)
            {
                Console.WriteLine(manufacturer.Name);
                foreach (var car in manufacturer.Cars)
                {
                    Console.WriteLine($"\t{car.Name} : {car.Combined}");
                }
            }
            Console.WriteLine("");

            var queryMethodSyntaxOwnFunction_ExtensionMethod =
                cars_DB.GroupBy(c => c.Manufacturer)
                .Select(g =>
                {
                    var results = g.CalculateCarsStatistics();
                    return new
                    {
                        Name = g.Key,
                        Max = results.Max,
                        Min = results.Min,
                        Avg = results.Average,
                        NumberOfCars = results.NumberOfCars
                    };
                })
                .OrderByDescending(r => r.Max);

            Console.WriteLine("Udskrift fra queryMethodSyntaxOwnFunction_Static");
            Console.WriteLine("");

            foreach (var result in queryMethodSyntaxOwnFunction_ExtensionMethod)
            {
                Console.WriteLine($"{result.Name} : ");
                Console.WriteLine($"\t Antal {result.Name} biler : {result.NumberOfCars}");
                Console.WriteLine($"\t Max : {result.Max}");
                Console.WriteLine($"\t Min : {result.Min}");
                Console.WriteLine($"\t Avg : {result.Avg}");
                Console.WriteLine("");
            }

            Console.WriteLine("");
        }
    }
}
