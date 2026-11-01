using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Collections.Models
{
    internal class User
    {
        private string _name;
        private int _age;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
}
