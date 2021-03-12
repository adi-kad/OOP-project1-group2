using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    /* 
    Inherits from Employee
    All Trainer objects will have the role of Trainer
    All Trainer objects will have a dictionary of available time slots that can be booked
    Contains methods to mark any specific time slot as booked or not (true or false)
    Contains a method to return all time slots for the object
    
    */
    class Trainer : Employee
    {
        private Dictionary<string, bool> schedule;
        public Trainer(int id, string name, string contactNumber) : base(id, name, contactNumber)
        {
            role = Role.Trainer;
            this.schedule = new Dictionary<string, bool>();
            schedule.Add("11:00-12:00", true);
            schedule.Add("12:00-13:00", true);
            schedule.Add("13:00-14:00", true);
            schedule.Add("14:00-15:00", true);
            schedule.Add("15:00-16:00", true);
            schedule.Add("16:00-17:00", true);
            schedule.Add("17:00-18:00", true);
        }
        public void ChangeScheduleFalse(string key)
        {
            schedule[key] = false;
        }
        public void ChangeScheduleTrue(string key)
        {
            schedule[key] = true;
        }
        public void PrintSchedule()
        {
            foreach (var n in schedule)
            {
                Console.WriteLine(n.Key + " " + n.Value);
            }
        }
    }
}
