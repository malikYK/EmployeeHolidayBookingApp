using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmpHolidayBookingData;


namespace EmpUserHanderBusiness
{
    public class UserHandler
    {
        public void MakeRequest(int employeeID, int managerID, string holidayID, DateTime startdate, DateTime enddate, int _duration, string status)
        {
            var newrequest = new HolidayRequestLog() { EmployeeID =  employeeID, HolidayId = holidayID, ManagerID = managerID, StartDate = startdate, EndDate = enddate,Duration =_duration ,Status = status };
            using (var db = new SouthwindContext())
            {
                db.HolidayRequestLogs.Add(newrequest);
                db.SaveChanges();
            }
        }
        public HolidayRequestLog SelectedRequest { get; set; }
        public void setselectedRequest(object _selectedRequest)
        {
            SelectedRequest = (HolidayRequestLog)_selectedRequest;
        }

        public void Approve_DenyRequestd(int HRLID, string status) 
        {
            using (var db = new SouthwindContext())
            {
                SelectedRequest = db.HolidayRequestLogs.Where(r => r.HolidayRequestLogID == HRLID).FirstOrDefault();
                {
                    SelectedRequest.Status = status;
                    db.SaveChanges();
                }
            }
        }

        public List<HolidayRequestLog> retriveAllRequets()
        {
            using (var db = new SouthwindContext())
            {

                return db.HolidayRequestLogs.ToList();
            }
        }

        public string calculateHolidayLengthMessage(int duration, string holtype)
        {
            if (duration >= 14 && holtype == "ANNU")
            {
                return "Please Contact manager about annual leave holidays that are expexted to be 2 weeks or more";
            }
            else if (duration >= 5 && holtype == "SICK")
            {
                return "Please Contact manager about sick leave that is expexted to be 5 days or more";
            }
            else
            {
                return "";
            }
        }

        public bool calculateHolidayLengthCheck(int duration, string holtype)
        {
            if (duration >= 14 && holtype == "ANNU")
            {
                return false;
            }
            else if (duration >= 5 && holtype == "SICK")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<Manager> AllManagers()
        {
            using (var db = new SouthwindContext())
            {
                return db.Managers.ToList();
            }
        }
        public List<Holiday> AllHolidays()
        {
            using (var db = new SouthwindContext())
            {
                return db.Holidays.ToList();
            }
        }

        public List<Employee> AllEmployees()
        {
            using (var db = new SouthwindContext())
            {
                return db.Employees.ToList();
            }
        }

       





    }
}
