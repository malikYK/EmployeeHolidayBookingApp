using System;
using System.Collections.Generic;
using System.Text;

namespace EmpHolidayBookingData
{
    public partial class Manager
    {
       
        public int ManagerID { get; set; }
        public string EmployeeID { get; set; }
        public int First_Name { get; set; }
        public int Last_Name { get; set; }

        public virtual Employee Employee { get; set; }

    }
}
