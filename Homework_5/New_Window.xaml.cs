using System.Windows;
using System.Data.SqlClient;
using System.Data;

namespace Homework_5
{
    /// <summary>
    /// Логика взаимодействия для New_Window.xaml
    /// </summary>
    public partial class New_Window : Window
    {
        SqlDataAdapter newadapter;
        DataTable newtable;

        public New_Window(SqlDataAdapter adapter,DataTable table)
        {
            InitializeComponent();
            newadapter = adapter;
            newtable = table;
          
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
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
                connection.Open();
                var sqlNewEmp = $@"INSERT INTO Employee (FirstName,SecondName,Fullname,Department)
                               VALUES (N'{FirstNameTB.Text}', N'{SecondNameTB.Text}', N'{SecondNameTB.Text +" "+ FirstNameTB.Text}', N'{DepartmentTB.Text}')";
                SqlCommand command = new SqlCommand(sqlNewEmp, connection);
                var number = command.ExecuteNonQuery();
                //    SqlCommand sel = new SqlCommand("SELECT FullName, Department FROM Employee", connection);
                //   newadapter.SelectCommand = sel;
                DataRow newRow = newtable.NewRow();
                newRow["FullName"] = SecondNameTB.Text + " " + FirstNameTB.Text;
                newRow["Department"] = DepartmentTB.Text;
                newtable.Rows.Add(newRow);
            }
            Close();
        }
    }
}
