using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            DepartmentName = departmentName;
        }


        public static ObservableCollection<Department> Dep_list { get => dep_list;}
        public string DepartmentName { get => _departmentName; set => _departmentName = value; }

        private static ObservableCollection<Department> dep_list = new ObservableCollection<Department>
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

