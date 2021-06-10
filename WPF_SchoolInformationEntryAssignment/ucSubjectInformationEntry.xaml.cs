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
    /// Interaction logic for ucSubjectInformationEntry.xaml
    /// </summary>
    public partial class ucSubjectInformationEntry : UserControl
    {
        public ucSubjectInformationEntry()
        {
            InitializeComponent();
        }

        private void mainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new ucMainMenu();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Entry for Subject {subjectName.Text} accepted.");

            //Clear the fields for the next entry
            subjectName.Text = "";
            subjectCourseId.Text = "";
            subjectSchool.Text = "";
            subjectCreditHours.Text = "";
        }
    }
}
