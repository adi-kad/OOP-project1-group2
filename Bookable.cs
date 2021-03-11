using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    abstract class Bookable
    {
        protected int id;
        protected Dictionary<string, bool> hours;
        protected string type;
        protected List<Booking> activeBookings;
        //Use current and maximum to see if room or tool is at max capacity.
        protected int maximum;
        protected int current;

        //Bookable times
        public Bookable(int id, string type) 
        {
            hours = new Dictionary<string, bool>();
            hours.Add("10:00-11:00", true);
            hours.Add("11:00-12:00", true);
            hours.Add("12:00-13:00", true);
            hours.Add("13:00-14:00", true);
            hours.Add("14:00-15:00", true);
            hours.Add("15:00-16:00", true);
            hours.Add("16:00-17:00", true);
            hours.Add("17:00-18:00", true);       
 
            this.id = id;
            this.type = type;
            activeBookings = new List<Booking>();
            this.current = 0;
        }
        public bool isAvailableAt(DateTime time)
        {
            /*
            NYI: Compare to the object's daily schedule
            */
            foreach(var booking in activeBookings)
            {
            //Check whether the given time is already occupied
            //by an active booking
                if(booking.isInBookingInterval(time))
                {
                    return false;
                }
            }
            //No scheduling conflicts found
            return true;
        }
        public bool isAvailableInTimeInterval(DateTime startTime, DateTime endTime)
        {
            foreach(var booking in activeBookings)
            {
                //Check if the time interval overlaps an existing booking period (assumed to be ordered and contiguous).
                if(booking.getStartTime() > startTime && booking.getStartTime() < endTime)
                {
                    return false;
                }
                else if(booking.getEndTime() > startTime && booking.getEndTime() < endTime)
                {
                    return false;
                }
            }
            return true; //No overlaps were found.
        }
    }
}
