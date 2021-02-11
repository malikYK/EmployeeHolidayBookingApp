using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EmpUserHanderBusiness;


namespace EmpBookingAppWPF
{
    /// <summary>
    /// Interaction logic for EmployeePage.xaml
    /// </summary>
    public partial class EmployeePage : Page
    {
        UserHandler _userHandler = new UserHandler();
        public EmployeePage()
        {
            InitializeComponent();
                
            ManagersComboBox.ItemsSource = _userHandler.AllManagers();
            Holiday_typecomboBox.ItemsSource = _userHandler.AllHolidays();
            emplpoyessComboBox.ItemsSource = _userHandler.AllEmployees();
            PopulateListBox();

        }
        private void PopulateListBox()
        {
            RequestListBox.ItemsSource = _userHandler.retriveAllRequets();
        }

        private void Button_Click(object sender, RoutedEventArgs e)

        {
            string emp = emplpoyessComboBox.Text;
            string employee = Convert.ToString(emp[0]);
            int EmployeeID = Convert.ToInt32(employee);

            string manager = ManagersComboBox.Text;         
            string _Manager = Convert.ToString(manager[0]);
            int _managerID = Convert.ToInt32(_Manager);

            string holiday = Holiday_typecomboBox.Text;
            string _holidayID = holiday.Substring(0, 4);
            DateTime _startDate = StartDatePicker.SelectedDate.Value;
            DateTime _endDate = EndDatePicker.SelectedDate.Value;
            int _duration = (Int32)( _endDate - _startDate).TotalDays;

            if (_userHandler.calculateHolidayLengthCheck(_duration, _holidayID))
            {
                _userHandler.MakeRequest(EmployeeID, _managerID, _holidayID, _startDate, _endDate, _duration, "Pending");

                MessageBox.Show("RequestMade");
                PopulateListBox();
            }
            else 
            {
                MessageBox.Show(_userHandler.calculateHolidayLengthMessage(_duration, _holidayID));

            }







        }
    }
}
