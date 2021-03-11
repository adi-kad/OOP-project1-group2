using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    class Administrator : Employee
    {
        public Administrator(int id, string name, string contactNumber) : base(id, name, contactNumber)
        {
            role = Role.Administrator;
        }
        public void setEmployeeAccess(int id, Role oldRole, Role newRole)
        // Function that takes in the id + old role (number value) + new role (number value)
        {
            // TBA
        }
        public void addActivity(int id, string type)
        {
            // Add new activity as bookable room to Facility
        }
    }
}
