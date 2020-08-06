using Microsoft.EntityFrameworkCore;
using Scott_Allen_Linq_Fundamentals.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scott_Allen_Linq_Fundamentals.Context
{
    public class DatabaseContext : DbContext
    {
        // Når der ikke angives nogen ConnectionString, vil Entity Framework pr. default
        // lave/oprette forbindelse til en databse med navn DatabaseContext på vores lokale
        // SQl Server : (LocalDb)\MSSQLLocalDB
        public DbSet<Car> Cars { get; set; }
    }
}
