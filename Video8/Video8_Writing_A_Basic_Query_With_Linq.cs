using System;
using System.Collections.Generic;
using System.Text;
using System.Linq
    ;
using Scott_Allen_Linq_Fundamentals.Context;
using Scott_Allen_Linq_Fundamentals.Files;

namespace Scott_Allen_Linq_Fundamentals.Video8
{
    public class Video8_Writing_A_Basic_Query_With_Linq
    {
        public static void Video8_Writing_A_Basic_Query_With_Linq_Start()
        {
            Console.WriteLine("");
            Console.WriteLine("Video8_Writing_A_Basic_Query_With_Linq");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");

            QueryData();
        }

        private static void QueryData()
        {
            int LoopCounter = 0;
            var db = new DatabaseContext();
            //db.Database. = Console.WriteLine;

            Console.WriteLine("");
            Console.WriteLine("Query Syntax");
            Console.WriteLine("");

            var queryQuerySyntax = from car in db.Cars
                                   orderby car.Combined descending, car.Name ascending
                                   select car;

            Console.WriteLine("");

            foreach (var car in queryQuerySyntax.Take(10))
            {
                Console.WriteLine($"{LoopCounter} : {car.Name} : {car.Combined}");
                LoopCounter++;
            }

            // Extension Method Syntax herunder.

            Console.WriteLine("");
            Console.WriteLine("Extension Method Syntax");
            Console.WriteLine("");

            var queryMethodSyntax = db.Cars.
                OrderByDescending(c => c.Combined).
                ThenBy(c => c.Name).
                Take(10);

            Console.WriteLine("");
            LoopCounter = 0;

            foreach (var car in queryMethodSyntax)
            {
                Console.WriteLine($"{LoopCounter} : {car.Name} : {car.Combined}");
                LoopCounter++;
            }


            var queryMethodSyntaxFilter = db.Cars.
                Where(c => c.Manufacturer == "BMW").
                OrderByDescending(c => c.Combined).
                ThenBy(c => c.Name).
                Take(10);

            Console.WriteLine("");
            LoopCounter = 0;

            foreach (var car in queryMethodSyntaxFilter)
            {
                Console.WriteLine($"{LoopCounter} : {car.Name} : {car.Combined}");
                LoopCounter++;
            }
        }
    }
}
