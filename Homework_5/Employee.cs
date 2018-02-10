using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
   public class Employee
    {

       
        private String _firstName;
        private String _secondName;
        private String _fullname;
        private Department _department;

        public Employee()
        {
        }

        public Employee(string firstName, string secondName, Department department)
        {
            FirstName = firstName;
            SecondName = secondName;
            _fullname = secondName + " " + firstName;
            Department = department;
        }



        public static ObservableCollection<Employee> Emp_list { get => emp_list; }
        public string Fullname { get => _fullname; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string SecondName { get => _secondName; set => _secondName = value; }
        public Department Department { get => _department; set => _department = value; }

        private static ObservableCollection<Employee> emp_list = new ObservableCollection<Employee>
            {
                new Employee("Иван", "Иванов", Department.Dep_list[0]),
                new Employee("Петр", "Третьков", Department.Dep_list[1]),
                new Employee("Владимир", "Крепов",Department.Dep_list[2])
            };
        public static Employee GetEmployee(String fullname)
        {
            for (int i = 0; i < Emp_list.Count; i++)
            {
                if (Emp_list[i].Fullname.Equals(fullname)) return Employee.Emp_list[i];
               
            }
            return null;
        }
    }
}
