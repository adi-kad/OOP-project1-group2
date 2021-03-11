using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    class Receptionist : Employee
    {
        public Receptionist(int id, string name, string contactNumber) : base(id, name, contactNumber)
        {
            this.role = Role.Receptionist;
            this.name = name;
            this.contactNumber = contactNumber;
        }
    }
}
