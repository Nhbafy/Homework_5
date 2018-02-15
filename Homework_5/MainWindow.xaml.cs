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

        ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            //Window editWindow = new Edit_Window(Employee.GetEmployee(EmpView.SelectedItem.ToString()))
            //{
            //    Owner = this
            //};
            //editWindow.ShowDialog();

        }

        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
        //    Window newWindow = new New_Window(adapter,dt);
         //   newWindow.ShowDialog();
        }
        

        private void TypeSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            if (selectedItem.Name =="Сотрудники")
            {

                EmpPanel.Visibility = Visibility.Visible;
                DepPanel.Visibility = Visibility.Hidden;
                foreach (DataTable dt in client.GetAllEmployee().Tables)
                {
                    EmpView.DataContext = dt.DefaultView;
                }
            }
            if (selectedItem.Name == "Департаменты")
            {
                EmpPanel.Visibility = Visibility.Hidden;
                DepPanel.Visibility = Visibility.Visible;
                foreach (DataTable dt in client.GetAllDeps().Tables)
                {
                    DepView.DataContext = dt.DefaultView;
                }

            }
        }
    }
 
}
