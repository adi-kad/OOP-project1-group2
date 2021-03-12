using System;

namespace OOP_project1_group2
{
    class Booking
    {
        /* 
        The class that handles a booking of something, either a group activity, room or specific training tool
        Will contain the object you want to book and the range of time want that object to be booked (start, end)
        */

        protected Bookable bookedItem;
        protected DateTime start, end;
        
        public Booking(Bookable item, DateTime start, DateTime end)
        {
            this.bookedItem = item;
            this.start = start;
            this.end = end;
        }
        
        public Bookable getItem()
        {
            return bookedItem;
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