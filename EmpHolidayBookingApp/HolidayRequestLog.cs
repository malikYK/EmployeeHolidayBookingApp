using System;
using System.Collections.Generic;
using System.Text;

namespace EmpHolidayBookingData
{
    public partial class HolidayRequestLog
    {
        
        public int HolidayRequestLogID { get; set; }
        public int EmployeeID { get; set; }
        public string HolidayId { get; set; }
        public int ManagerID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? Duration { get; set; }
        public string Status { get; set;}

        public virtual Employee Employee { get; set; }
        public virtual Holiday Holiday { get; set; }
        public virtual Manager Manager { get; set; }

        public override string ToString()
        {
            return EmployeeID+ " " + HolidayId + " " + ManagerID + " " + StartDate.ToString("dd/MM/yyyy") + " " + EndDate.ToString("dd/MM/yyyy") + " " + Status;
        }


    }
}
