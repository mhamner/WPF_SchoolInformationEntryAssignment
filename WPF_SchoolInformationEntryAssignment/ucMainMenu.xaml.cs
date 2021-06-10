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
    /// Interaction logic for ucMainMenu.xaml
    /// </summary>
    public partial class ucMainMenu : UserControl
    {
        public ucMainMenu()
        {
            InitializeComponent();
        }

        private void enterStudentInformation_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new ucStudentInformationEntry();
        }

        private void enterTeacherInformation_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new ucTeacherInformationEntry();
        }

        private void enterSubjectInformation_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new ucSubjectInformationEntry();
        }
    }
}
