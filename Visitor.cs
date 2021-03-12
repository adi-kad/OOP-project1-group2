using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    class Visitor : Person
    {
        /* 
        Inherits from the Person class
        Represent every visitor to the gym
        Contains a List of all active bookings for that specific visitor
        We store the name and contact number as we need it in case a booked activity/tool gets cancelled
        Every visitor object also contains a bool value if they have a training schedule made with a trainer
        A visitor can not book a training section with a trainer if they lack a training schedule
        In that case, they can instead book a time slot with a trainer to create this
        */

        private List<Booking> activeBookings; // TBA
        private bool hasSchedule;

        public Visitor(string name, string contactNumber) : base(name, contactNumber)
        {
            hasSchedule = false;
            activeBookings = new List<Booking>();
        }
        
        public bool createBooking(Bookable item, DateTime start, DateTime end)
        {
            bool success = false;
            Booking booking = item.book(start, end);
            if(booking != null)
            {
                activeBookings.Add(booking);
                success = true;
            }
            return success;
        }
        
        public bool joinGroupActivity(GroupActivity activity)
        {
            return activity.addParticipant(this);
        }
        
        public bool leaveGroupActivity(GroupActivity activity)
        {
            return activity.removeParticipant(this);
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
        
        public bool cancelBooking(Booking booking)
        {
            //return bool to indicate whether the removal succeeded.
            return activeBookings.Remove(booking) && booking.getItem().removeBooking(booking);
        }
    }
}
