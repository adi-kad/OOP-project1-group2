using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    class GroupActivity : Booking
    {
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
