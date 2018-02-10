using System.Windows;
using System.Windows.Controls;
using System.Configuration;
using System.Data.SqlClient;


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
            var connectionString = new SqlConnectionStringBuilder
            {
                DataSource = @"(LocalDb)\MSSQLLocalDB",
                InitialCatalog = "MyBD"
            }.ConnectionString;
        }

       

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Window editWindow = new Edit_Window(Employee.GetEmployee(ViewEmployee.SelectedItem.ToString()))
            {
                Owner = this
            };
            editWindow.ShowDialog();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow = new New_Window();
            newWindow.ShowDialog();
        }
    }
 
}
