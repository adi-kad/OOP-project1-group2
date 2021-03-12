using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    /* 
    Inherits name & contactnumber from the Person class
    Creates a enum containing all roles for the system
    Contains methods to return different types of employee information, like name, contact number and id
    */
    
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
        public string getAllEmployeeInfo()
        {
            return ($"{role} {id} {name} {contactNumber}\n");
        }
        public string getEmployeeName()
        {
            return name;
        }
        public int getEmployeeId()
        {
            return id;
        }
        public string GetEmployeeContactNumber()
        {
            return contactNumber;
        }
    }
}
