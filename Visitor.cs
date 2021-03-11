using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    class Visitor : Person
    {
        private List<Booking> activeBookings; // TBA
        private bool hasSchedule;

        public Visitor(string name, string contactNumber) : base(name, contactNumber)
        {
            hasSchedule = false;
            activeBookings = new List<Booking>();
        }
        public string getContactInfo()
        {
            return name + " " + contactNumber;
        }
        public List<Booking> getActiveBookings()
        {
            return activeBookings;
        }
        public bool hasTrainingSchedule()
        {
            return hasSchedule;
        }
        public bool createBooking(Bookable item, DateTime start, DateTime end)
        {
            bool success = false;
            if(item.isAvailableInTimeInterval(start, end))
            {
                activeBookings.Add(new Booking(item, start, end));
                success = true;
            }
            return success;
        }
        public bool cancelBooking(Booking booking)
        {
            //List.Remove() returns a bool to indicate whether the removal succeeded.
            return activeBookings.Remove(booking);
        }
    }
}
