using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Scott_Allen_Linq_Fundamentals.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scott_Allen_Linq_Fundamentals.Context
{
    public class DatabaseContext : DbContext
    {
        private bool _useDatabaseLogging = false;
        private DbContextOptionsBuilder optionsBuilderStore;

        public bool UseDatabaseLogging
        {
            get 
            {
                return this._useDatabaseLogging;            
            }
            set
            {
                this._useDatabaseLogging = value;

                //DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();

                if (true == this._useDatabaseLogging)
                {
                    MyLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
                }
                else
                {
                    //MyLoggerFactory = LoggerFactory.Create(builder => { builder.ClearProviders(); });
                    MyLoggerFactory = null;
                }
                if (null != optionsBuilderStore)
                {
                    optionsBuilderStore.UseLoggerFactory(MyLoggerFactory);
                }
            }
        }
        public DbSet<Car> Cars { get; set; }

        //public readonly ILoggerFactory MyLoggerFactory;
        private ILoggerFactory MyLoggerFactory;

        public DatabaseContext(bool UseDatabaseLogging = false)
        {
            if (true == UseDatabaseLogging)
            {
                this.UseDatabaseLogging = true;
            }
            //MyLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
        }
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=Cars;Trusted_Connection=True;");

            if (true == this._useDatabaseLogging)
            {
                MyLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
            }
            else
            {
                //MyLoggerFactory = LoggerFactory.Create(builder => { builder.ClearProviders(); });
                MyLoggerFactory = null;
            }

            optionsBuilder.UseLoggerFactory(MyLoggerFactory);

            this.optionsBuilderStore = optionsBuilder;
        }
    }
}
