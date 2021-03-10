using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    enum Role
    {
        Receptionist,
        Trainer,
        Administrator
    }
    class Employee : Person
    {
        private int id;
        protected Role role;

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
