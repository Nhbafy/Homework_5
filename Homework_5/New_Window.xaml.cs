using System.Windows;
using System.Data.SqlClient;

namespace Homework_5
{
    /// <summary>
    /// Логика взаимодействия для New_Window.xaml
    /// </summary>
    public partial class New_Window : Window
    {

        public New_Window()
        {
            InitializeComponent();
          
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = new SqlConnectionStringBuilder
            {
                DataSource = @"(LocalDb)\MSSQLLocalDB",
                InitialCatalog = "MyBD"
            }.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var sqlNewEmp = $@"INSERT INTO Employee (FirstName,SecondName,Fullname,Department)
                               VALUES ('{FirstNameTB.Text}', '{SecondNameTB.Text}', '{SecondNameTB.Text +" "+ FirstNameTB.Text}', '{DepartmentTB.Text}')";

                connection.Open();
                SqlCommand command = new SqlCommand(sqlNewEmp, connection);
                var number = command.ExecuteNonQuery();
            }
            this.Close();
        }
    }
}
