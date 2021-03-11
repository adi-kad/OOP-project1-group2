using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    class GroupActivity : Booking
    {
        private Trainer coach;
        private List<Visitor> participants;
        
        public GroupActivity(BookableRoom room, DateTime start, DateTime end, Trainer coach) : base(room, start, end)
        {
            this.coach = coach;
        }
        
        public bool addParticipant(Visitor visitor)
        {
            bool success = (participants.length < bookedItem.getMaxCapacity());
            if(success)
            {
                participants.Add(visitor);
            }
        }
        
        public void cancelActivity()
        {
            foreach(var visitor in participants)
            {
                //Send texts to notify all participants of the cancellation.
            }
        }
        
        public bool removeParticipant(Visitor visitor)
        {
            return participants.Remove(visitor);
        }
    }
}