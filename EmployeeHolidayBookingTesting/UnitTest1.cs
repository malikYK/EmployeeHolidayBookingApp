using NUnit.Framework;

using EmpUserHanderBusiness;
using EmpHolidayBookingData;
using System.Linq;
using System;

namespace EmployeeHolidayBookingTesting
{
    public class Tests
    {

        UserHandler _userHandler = new UserHandler();

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        
        public void WhenARequestIsAdded_TheNumberOfREqustsIncreasesBy1()
        {
            using (var Testingdb = new SouthwindContext())
            {
                DateTime StartDate = new DateTime(2020,3,12);
                DateTime EndDate = new DateTime(2020,3,15);

                var NumOfRequestsBefore = Testingdb.HolidayRequestLogs.Count();
                _userHandler.MakeRequest( 1, 1, "SICK", StartDate, EndDate,3, "pending");

                var NumOfRequestsafter = Testingdb.HolidayRequestLogs.Count();

                Assert.AreEqual(NumOfRequestsBefore + 1, NumOfRequestsafter);

            }

        }

        [Test]
        public void RequestIsOnlyMadeWhenItIsUnder14DaysFalseAndAnnualLeave() 
        {
            
            DateTime StartDate = new DateTime(2020, 3, 12);
            DateTime EndDate = new DateTime(2020, 6, 15);

            int duration = (int)(EndDate - StartDate).TotalDays;


            Assert.IsFalse(_userHandler.calculateHolidayLengthCheck(duration, "ANNU"));
        }
        [Test]
        public void RequestIsOnlyMadeWhenItIsUnder14DaysTrueAnnualleave()
        {

            DateTime StartDate = new DateTime(2020, 3, 12);
            DateTime EndDate = new DateTime(2020, 3, 15);

            int duration = (int)(EndDate - StartDate).TotalDays;


            Assert.IsTrue(_userHandler.calculateHolidayLengthCheck(duration, "ANNU"));
        }
        [Test]
        public void RequestIsOnlyMadeWhenItIsUnder6DaysFalseAndSickLeave()
        {

            DateTime StartDate = new DateTime(2020, 3, 12);
            DateTime EndDate = new DateTime(2020, 3, 18);

            int duration = (int)(EndDate - StartDate).TotalDays;


            Assert.IsFalse(_userHandler.calculateHolidayLengthCheck(duration, "SICK"));
        }

        [Test]
        public void RequestIsOnlyMadeWhenItIsUnder6DaysTrueAndSickLeave()
        {

            DateTime StartDate = new DateTime(2020, 3, 12);
            DateTime EndDate = new DateTime(2020, 3, 16);

            int duration = (int)(EndDate - StartDate).TotalDays;


            Assert.IsTrue(_userHandler.calculateHolidayLengthCheck(duration, "SICK"));
        }



    }
}