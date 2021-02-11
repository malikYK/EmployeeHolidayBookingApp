using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;



namespace EmpHolidayBookingData
{
    public partial class SouthwindContext : DbContext
    {
        public static SouthwindContext instance { get; } = new SouthwindContext();

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Manager> Managers { get; set; }

        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<HolidayRequestLog> HolidayRequestLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        { 
            if (!options.IsConfigured) 
            {
                options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Southwind");
            }
        }


    }
}
