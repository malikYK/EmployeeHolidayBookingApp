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
            AllRequestsList.ItemsSource = _userhandler.retriveAllRequets();
        }
    }
}
