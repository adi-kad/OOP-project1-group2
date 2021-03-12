using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    class GroupActivity : Booking
    {
        /* 
        Inherits from the booking class
        Represent a bookable group activity that takes place in a bookableRoom
        Every object will contain a training coach (or null) and a list of all participants linked to that acitivy
        Has methods to add new visitors the activity.
        If a group activity gets cancelled, a message will be sent to all participants involved in that object
        */
    
        private Trainer coach;
        private string description;
        private List<Visitor> participants;
        
        public GroupActivity(BookableRoom room, DateTime start, DateTime end, Trainer coach, string description) : base(room, start, end)
        {
            this.coach = coach;
            this.description = description;
            this.participants = new List<Visitor>();
        }
        
        public bool addParticipant(Visitor visitor)
        {
            bool success = (participants.Count < bookedItem.getMaxCapacity());
            if(success)
            {
                participants.Add(visitor);
            }
            return success;
        }
        
        public void cancelActivity()
        {
            foreach(var visitor in participants)
            {
                visitor.sendMessage("One of your planned group activities (" + 
                description + ") has been cancelled. Please review your schedule.");
                visitor.leaveGroupActivity(this);
            }
            this.bookedItem.removeBooking(this);
        }
        
        public string getDescription()
        {
            return description;
        }
        
        public bool removeParticipant(Visitor visitor)
        {
            return participants.Remove(visitor);
        }
    }
}
