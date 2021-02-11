using System;
using EmpHolidayBookingAppData;
using EmpUserHanderBusiness;

namespace UserHander
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            UserHandler _userHandler = new UserHandler();

            Console.WriteLine(_userHandler.AllManagers());



        }
    }
}
