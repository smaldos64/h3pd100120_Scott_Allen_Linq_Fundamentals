using Scott_Allen_Linq_Fundamentals.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scott_Allen_Linq_Fundamentals.Statistics
{
    public class CarStatistics
    {
        public int Max { get; set; }
        public int Min { get; set; }
        
        public double Average { get; set; }

        public int Total { get; set; }
        
        public int NumberOfCars { get; set; }

        public CarStatistics()
        {
            Max = Int32.MinValue;
            Min = Int32.MaxValue;
        }

        public CarStatistics Accumulate(Car car)
        {
            NumberOfCars++;
            Total += car.Combined;
            Max = Math.Max(Max, car.Combined);
            Min = Math.Min(Min, car.Combined);

            return (this);
        }

        public CarStatistics Compute()
        {
            Average = Total / NumberOfCars;

            return (this);
        }

        public static CarStatistics CalculateCarsStatistics_Static(IEnumerable<Car> car_List)
        {
            CarStatistics theseCarsStatictics = new CarStatistics();
            
            foreach (var car in car_List)
            {
                theseCarsStatictics.Accumulate(car);
            }
            theseCarsStatictics.Compute();

            return theseCarsStatictics;
        }

        public CarStatistics CalculateCarsStatistics_Object(IEnumerable<Car> car_List)
        {
            CarStatistics theseCarsStatictics = new CarStatistics();

            foreach (var car in car_List)
            {
                theseCarsStatictics.Accumulate(car);
            }
            theseCarsStatictics.Compute();

            return theseCarsStatictics;
        }

    }
}
