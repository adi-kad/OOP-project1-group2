using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    class Employee : Person
    {
        private List<int> activeBookings; // TBA
        private bool trainingSchedule;

        public Employee(string name, string contactNumber) : base(name, contactNumber)
        {
            trainingSchedule = false;
            activeBookings = new List<int>();
        }
    }
}
