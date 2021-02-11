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
    /// Interaction logic for ManagerPage.xaml
    /// </summary>
    public partial class ManagerPage : Page
    {
        UserHandler _userhandler = new UserHandler();
        public ManagerPage()
        {
            InitializeComponent();
            PopulateListBox();



        }
        private void PopulateListBox()
        {
            RequestList.ItemsSource = _userhandler.retriveAllRequets();
        }

        private void PopulateHolidayRequestLogFields()
        {
            if (_userhandler.SelectedRequest != null)
            {
                EmployeesTB.Text = _userhandler.SelectedRequest.EmployeeID.ToString();
                HolidaysTB.Text = _userhandler.SelectedRequest.HolidayId;
                ManagersTB.Text = _userhandler.SelectedRequest.ManagerID.ToString();
                StartDateTB.Text = _userhandler.SelectedRequest.StartDate.ToString(("dd/MM/yyyy"));
                EndDateTB.Text = _userhandler.SelectedRequest.EndDate.ToString(("dd/MM/yyyy"));
            }
        }
        

        private void RequestSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RequestList.SelectedItem != null)
            {
                _userhandler.setselectedRequest(RequestList.SelectedItem);
                PopulateHolidayRequestLogFields();
            }
        }
        private void ClearTBs() 
        {
            EmployeesTB.Text = "";
            HolidaysTB.Text = "";
            ManagersTB.Text = "";
            StartDateTB.Text = "";
            EndDateTB.Text = "";
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            int HRLID = _userhandler.SelectedRequest.HolidayRequestLogID;
            string _status = StatusComboBox.Text;
            _userhandler.Approve_DenyRequestd(HRLID, _status);

            PopulateListBox();
            
            ClearTBs();




        }
    }   
}
