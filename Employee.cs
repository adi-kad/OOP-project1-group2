using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    class Employee : Person
    {
        private int id;

        public Employee(int id, string name, string contactNumber) : base(name, contactNumber)
        {
            this.id = id;
        }
        public string getEmployeeInfo()
        {
            return id + " " + name + " " + contactNumber;
        }
    }
}
