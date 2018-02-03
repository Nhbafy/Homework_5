using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class Types
    {
        private String _type_name;
        public Types(string type_name)
        {
            _type_name = type_name;
        }

        public string Type_name { get => _type_name;}
    }
}
