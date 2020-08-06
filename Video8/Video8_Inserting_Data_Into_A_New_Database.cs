using Microsoft.EntityFrameworkCore.Storage;
using Scott_Allen_Linq_Fundamentals.Context;
using Scott_Allen_Linq_Fundamentals.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Scott_Allen_Linq_Fundamentals.Video8
{
    public class Video8_Inserting_Data_Into_A_New_Database
    {
        public static void Video8_Inserting_Data_Into_A_New_Database_Start()
        {
            InsertData();
            QueryData();
        }

        private static void QueryData()
        {
            throw new NotImplementedException();
        }

        private static void InsertData()
        {
            var cars = ProcessDataFromFiles.ProcessCar("fuel.csv");
            var db = new DatabaseContext();

            if (!db.Cars.Any())
            {
                Console.WriteLine("Inserting Data into Database !!!");
                foreach (var car in cars)
                {
                    db.Cars.Add(car);
                }
                db.SaveChanges();
                Console.WriteLine("Data has been inserted into Database !!!");
            }
        }
    }
}
