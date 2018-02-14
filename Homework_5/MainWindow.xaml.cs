using System.Windows;
using System.Windows.Controls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace Homework_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();

        
        public MainWindow()
        {
            InitializeComponent();
            EmpView.DataContext = dt.DefaultView;
            client.
            #region
            //var connectionString = new SqlConnectionStringBuilder
            //{
            //    DataSource = @"(LocalDb)\MSSQLLocalDB",
            //    InitialCatalog = "MyBD"
            //}.ConnectionString;


            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand("SELECT FullName, Department FROM Employee", connection);
            //    adapter.SelectCommand = command;
            //    adapter.Fill(dt);
            //}

            //string sql = "SELECT * FROM Employee";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlDataAdapter adapter = new SqlDataAdapter();
            //    adapter.SelectCommand = new SqlCommand(sql, connection);
            //    DataTable dt = new DataTable();
            //    adapter.Fill(dt);
            //    EmpView.DataContext = dt.DefaultView;
            //}
            #endregion
        }



        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            //Window editWindow = new Edit_Window(Employee.GetEmployee(EmpView.SelectedItem.ToString()))
            //{
            //    Owner = this
            //};
            //editWindow.ShowDialog();
            MessageBox.Show(client.HelloWorld());
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            Window newWindow = new New_Window(adapter,dt);
            newWindow.ShowDialog();
        }
    }
 
}
