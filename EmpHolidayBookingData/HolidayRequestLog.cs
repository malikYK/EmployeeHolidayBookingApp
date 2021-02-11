using System;
using System.Collections.Generic;

namespace EmpHolidayBookingData
{
    public partial class HolidayRequestLog
    {
        public HolidayRequestLog()
        {
            Managers = new HashSet<Manager>();

        }
        public string EmployeeID { get; set; }
        public string HolidayId { get; set; }
        public string ManagerID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? Duration { get; set; }
        public int Status { get; set;}
        public virtual Employee Employee { get; set; }

        public virtual Holiday Holiday { get; set; }
        public virtual ICollection<Manager> Managers { get; set; }
    }
}
