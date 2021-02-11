using System;
using System.Collections.Generic;
using System.Text;

namespace EmpHolidayBookingData
{
    public partial class Manager
    {
       
        public int ManagerID { get; set; }
        public int EmployeeID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }


        public virtual Employee Employee { get; set; }


        public override string ToString()
        {
            return ManagerID+" "+First_Name + " " + Last_Name;
        }

    }

}
