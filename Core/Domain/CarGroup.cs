using System;
using System.Collections.Generic;
using System.Text;

namespace Scott_Allen_Linq_Fundamentals.Core.Domain
{
    public class CarGroup
    {
        public string Name { get; set; }

        public List<Car> Cars { get; set; }

        public CarGroup(string Name, List<Car> Cars)
        {
            this.Name = Name;
            this.Cars = Cars;
        }
    }
}
