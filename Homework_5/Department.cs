using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
  public  class Department
    {
        private String _departmentName;

        public Department(string departmentName)
        {
            _departmentName = departmentName;
        }

        public string DepartmentName { get => _departmentName;}

        public static List<Department> Dep_list { get => dep_list;}

        private static List<Department> dep_list = new List<Department>
            {
                new Department("Департамент качества"),
                new Department("Департамент разработки"),
                new Department("Департамент аналитики")
            };

        public static Department GetDepartment(String departmentName)
        {
            for (int i = 0; i < dep_list.Count; i++)
            {
                if (dep_list[i].DepartmentName.Equals(departmentName)) return dep_list[i];

            }
            return null;
        }
    }
}

