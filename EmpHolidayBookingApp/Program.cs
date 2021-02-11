using System;
using System.Collections.Generic;
using System.Text;
using EmpHolidayBookingData;
using Microsoft.EntityFrameworkCore;

namespace EmpHolidayBookingApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            using (var db = new SouthwindContext())
            {
                // Create
                Console.WriteLine("Creating some Employees");
                //db.Add(new Employee() {First_Name = "Malik", Last_Name = "Jn-Louis", Age = 21, Address = "Hackney", City = "London", Phone = "07473453789" });
                //db.Add(new Employee() { First_Name = "Grayce", Last_Name = "Fitchen", Age = 25, Address = "Haringey", City = "London", Phone = "07858706175" });
                //db.Add(new Employee() { First_Name = "Ryan", Last_Name = "Luker", Age = 30, Address = "Camden", City = "London", Phone = "07731561311" });
                //db.Add(new Employee() { First_Name = "Taylor", Last_Name = "Artrick", Age = 27, Address = "Chelsea", City = "London", Phone = "07809662341" });
                //db.Add(new Employee() { First_Name = "Laura", Last_Name = "Duddle", Age = 22, Address = "Lewisham", City = "London", Phone = "07933842440" });

                Console.WriteLine("Creating some Managers");
                //db.Add(new Manager() { EmployeeID = 3, First_Name = "Ryan", Last_Name = "Luker" });
                //db.Add(new Manager() { EmployeeID = 4, First_Name = "Taylor", Last_Name = "Artrick" });
                DateTime _startdate = new DateTime(2020, 1, 11);
                DateTime _endDate = new DateTime(2020, 1,12 );


                db.Add(new HolidayRequestLog() { EmployeeID = 1, ManagerID = 1, HolidayId = "ANNU", StartDate = _startdate, EndDate = _endDate, Status = "Pending" });

              




                
                //db.Add(new Holiday() {HolidayId ="ANN", HolidayType = "Annual Leave", Description= "Workers in the UK are legally entitled to 5.6 weeks paid holiday a year" });
                //db.Add(new Holiday() { HolidayId = "SICK", HolidayType = "Sick leave", Description = "Employees can take time off work if they're ill. They need to give their employer proof if they're ill for more than 7 days" });
                //db.Add(new Holiday() { HolidayId = "MATE", HolidayType = "Maternity leave", Description = "time off from a job given a mother to take care of a newborn child " });
                //db.Add(new Holiday() { HolidayId = "COMP", HolidayType = "Compassionate  leave", Description = " employers grant employees off work for death in their family or of a close loved one, allowing them time to grieve, make arrangements and attend the funeral." });
                


                db.SaveChanges();
                Console.WriteLine("Fin");
            }
        }
    }
}



