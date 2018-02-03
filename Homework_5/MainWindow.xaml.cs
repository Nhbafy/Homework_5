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

namespace Homework_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();





            List<Types> typesList = new List<Types>
            {
                new Types ("Employee"),
                new Types ("Department")
            };

        }

        private void ComboBoxTypes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            LeftList.Items.Clear();
            RightList.Visibility = Visibility.Hidden;
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            
            if (selectedItem.Equals(comboBox.Items[0]))
            {

                SelectEmployee();
            }
            if (selectedItem.Equals(comboBox.Items[1]))
            {
                SelectDepartment();
            }

        }

        public void SelectEmployee()
        {
            LeftList.Visibility = Visibility.Visible;

            for (int i = 0; i < Employee.Emp_list.Count; i++)
            {
                LeftList.Items.Add(Employee.Emp_list[i].Fullname);
            }
        }
        public void SelectDepartment()
        {
            LeftList.Visibility = Visibility.Visible;

            for (int i = 0; i < Department.Dep_list.Count; i++)
            {
                LeftList.Items.Add(Department.Dep_list[i].DepartmentName);
            }
        }


        private void LeftList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RightList.Items.Clear();
            ListBox listbox = (ListBox)sender;
            if (listbox.SelectedItem != null)
            {

                if (ComboBoxTypes.SelectedIndex == 0)
                {

                    RightList.Visibility = Visibility.Visible;
                    RightList.Items.Add(Employee.GetEmployee(listbox.SelectedItem.ToString()).Department.DepartmentName);
                }
                if (ComboBoxTypes.SelectedIndex == 1)
                {

                    RightList.Visibility = Visibility.Visible;
                    for (int i = 0; i < Employee.Emp_list.Count; i++)
                    {
                        if (listbox.SelectedItem.ToString().Equals(Employee.Emp_list[i].Department.DepartmentName))
                        {
                            RightList.Items.Add(Employee.Emp_list[i].Fullname);
                        }
                    }

                }
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow = new New_Window (Employee.GetEmployee(LeftList.SelectedItem.ToString()))
            {
                Owner = this
            };
            newWindow.Show();
        }
    }

 
}
