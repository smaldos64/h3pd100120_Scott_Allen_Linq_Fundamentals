using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Scott_Allen_Linq_Fundamentals.Extensions;
using Scott_Allen_Linq_Fundamentals.Files;
using Scott_Allen_Linq_Fundamentals.Statistics;


namespace Scott_Allen_Linq_Fundamentals.Video6
{
    class Video6_Aggregation_With_Extended_Method
    {
        public static void Video6_Aggregation_With_Extended_Method_Start()
        {
            Console.WriteLine("");
            Console.WriteLine("Video6_Aggreating_Data");
            Console.WriteLine("----------------------");
            Console.WriteLine("");

            var cars = ProcessDataFromFiles.ProcessCar("fuel.csv");
            var manufacturers = ProcessDataFromFiles.ProcessManufacturers("manufacturers.csv");

            // Extension Method Syntax herunder.
            
            Console.WriteLine("Extension Method Syntax");
            Console.WriteLine("");
            Console.WriteLine("");

            var queryMethodSyntaxOwnFunction_Static =
                cars.GroupBy(c => c.Manufacturer)
                .Select(g =>
                {
                    var results = CarStatistics.CalculateCarsStatistics_Static(g);
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

            foreach (var result in queryMethodSyntaxOwnFunction_Static)
            {
                Console.WriteLine($"{result.Name} : ");
                Console.WriteLine($"\t Antal {result.Name} biler : {result.NumberOfCars}");
                Console.WriteLine($"\t Max : {result.Max}");
                Console.WriteLine($"\t Min : {result.Min}");
                Console.WriteLine($"\t Avg : {result.Avg}");
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            var queryMethodSyntaxOwnFunction_Object =
                cars.GroupBy(c => c.Manufacturer)
                .Select(g =>
                {
                    CarStatistics carStatistics_Object = new CarStatistics();
                    var results = carStatistics_Object.CalculateCarsStatistics_Object(g);
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

            Console.WriteLine("Udskrift fra queryMethodSyntaxOwnFunction_Object");
            Console.WriteLine("");

            foreach (var result in queryMethodSyntaxOwnFunction_Object)
            {
                Console.WriteLine($"{result.Name} : ");
                Console.WriteLine($"\t Antal {result.Name} biler : {result.NumberOfCars}");
                Console.WriteLine($"\t Max : {result.Max}");
                Console.WriteLine($"\t Min : {result.Min}");
                Console.WriteLine($"\t Avg : {result.Avg}");
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            var queryMethodSyntaxOwnFunction_ExtensionMethod =
                cars.GroupBy(c => c.Manufacturer)
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
            Console.WriteLine("");

            var queryMethodSyntax_From_Scott_Allen_PLuralsight_Video =
                cars.GroupBy(c => c.Manufacturer)
                .Select(g =>
                {
                    var results = g.Aggregate(new CarStatistics(),
                                             (acc, c) => acc.Accumulate(c),
                                              acc => acc.Compute());
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
            //  Ved at bruge syntaksen/ metoden herover undgår vi at skulle
            //  løbe igennem alle Cars 3 gange for at finde henholdsvis Max, Min
            //  og Average værdier.

            Console.WriteLine("Udskrift fra queryMethodSyntax_From_Scott_Allen_PLuralsight_Video");
            Console.WriteLine("");

            foreach (var result in queryMethodSyntax_From_Scott_Allen_PLuralsight_Video)
            {
                Console.WriteLine($"{result.Name} : ");
                Console.WriteLine($"\t Antal {result.Name} biler : {result.NumberOfCars}");
                Console.WriteLine($"\t Max : {result.Max}");
                Console.WriteLine($"\t Min : {result.Min}");
                Console.WriteLine($"\t Avg : {result.Avg}");
                Console.WriteLine("");
            }
        }
    }
}
