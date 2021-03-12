using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    class BookableRoom : Bookable
    {
        public BookableRoom(int id, string type) : base(id, type)
        {
            this.maxCapacity = 20;
        }
        
        public GroupActivity book(DateTime start, DateTime end, Trainer coach, string description)
        {
            GroupActivity activity = null;
            if(this.isAvailableInTimeInterval(start, end))
            {
                activity = new GroupActivity(this, start, end, coach, description);
                this.activeBookings.Add(activity);
            }
            return activity;
        }
        
        public Dictionary<string, bool> getSchedule()
        {
            return hours;
        }
        
        public override string ToString()
        {
            return id.ToString() + " " + type;
        }
    }
}
