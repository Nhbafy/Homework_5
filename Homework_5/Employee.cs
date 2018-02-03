using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
   public class Employee
    {
        private String _firstName;
        private String _secondName;
        private int _age;
        private String _fullname;
        private Department _department;

        public Employee(string firstName, string secondName, int age, Department department)
        {
            _firstName = firstName;
            _secondName = secondName;
            this._age = age;
            _fullname = secondName + " " + firstName;
            _department = department;
        }

        public string FirstName { get => _firstName; }
        public string SecondName { get => _secondName; }
        public int Age { get => _age; }
        public static List<Employee> Emp_list { get => emp_list; }
        public string Fullname { get => _fullname; }
        public Department Department { get => _department; }

        private static List<Employee> emp_list = new List<Employee>
            {
                new Employee("Иван", "Иванов", 34, Department.Dep_list[0]),
                new Employee("Петр", "Третьков", 23, Department.Dep_list[1]),
                new Employee("Владимир", "Крепов", 40, Department.Dep_list[2])
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
