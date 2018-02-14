using System.Windows;


namespace Homework_5
{
    /// <summary>
    /// Логика взаимодействия для Edit_Window.xaml
    /// </summary>
    public partial class Edit_Window : Window
    {
        private Employee _employee;
        public Edit_Window (Employee employee)
        {
            InitializeComponent();
            FirstNameTB.Text = employee.FirstName;
            SecondNameTB.Text = employee.SecondName;
            DepartmentTB.Text = employee.Department.DepartmentName;

            _employee = employee;
        }


        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            _employee.FirstName = FirstNameTB.Text;
            _employee.SecondName = SecondNameTB.Text;
            _employee.Department.DepartmentName = DepartmentTB.Text;
            
            Close();
        }
    }
}
