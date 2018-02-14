using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string connectionString = new SqlConnectionStringBuilder
        {
            DataSource = @"(LocalDb)\MSSQLLocalDB",
            InitialCatalog = "MyBD"
        }.ConnectionString;

        [WebMethod]
      public  DataTable GetAllEmployee()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT FullName, Department FROM Employee", connection);
                adapter.SelectCommand = command;
                adapter.Fill(dt);
            }
            return dt;
        }

        



        [WebMethod]
        public string HelloWorld()
        {
            return "Привет всем!";
        }

        
        //[WebMethod]
        //object GetEmployee()
        //{
        //    return object;
        //}
    }
}
