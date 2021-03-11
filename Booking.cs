using System;

namespace OOP_project1_group2
{
    class Booking
    {
        private Bookable bookedItem;
        private DateTime start, end;
        
        public Booking(Bookable item, DateTime start, DateTime end)
        {
            this.bookedItem = item;
            this.start = start;
            this.end = end;
        }
        
        public DateTime getStartTime()
        {
            return start;
        }
        
        public DateTime getEndTime()
        {
            return end;
        }
        
        public bool isInBookingInterval(DateTime time)
        {
            return (time > start && time < end);
        }
    }
}