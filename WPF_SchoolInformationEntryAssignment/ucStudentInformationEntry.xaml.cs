using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_SchoolInformationEntryAssignment
{
    /// <summary>
    /// Interaction logic for ucSchoolInformationEntry.xaml
    /// </summary>
    public partial class ucStudentInformationEntry : UserControl
    {
        public ucStudentInformationEntry()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Entry for Student {studentFirstName.Text} {studentLastName.Text} accepted.");

            //Clear the fields for the next entry
            studentFirstName.Text = "";
            studentLastName.Text = "";
            studentAddressLine1.Text = "";
            studentAddressLine2.Text = "";
            studentCity.Text = "";
            studentState.Text = "";
            studentZip.Text = "";
            studentEmail.Text = "";
            studentPhone.Text = "";
        }

        private void mainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new ucMainMenu();
        }
    }
}
