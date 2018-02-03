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
using System.Windows.Shapes;

namespace Homework_5
{
    /// <summary>
    /// Логика взаимодействия для New_Window.xaml
    /// </summary>
    public partial class New_Window : Window
    {
        public New_Window (Employee employee)
        {
            InitializeComponent();
            FirstNameTB.Text = employee.FirstName;
            SecondNameTB.Text = employee.SecondName;
            DepartmentTB.Text = employee.Department.DepartmentName;
        }


        private void FirstNameTB_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
