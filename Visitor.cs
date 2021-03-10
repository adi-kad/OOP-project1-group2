using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    class Visitor : Person
    {
        private List<int> activeBookings; // TBA
        private bool trainingSchedule;

        public Visitor(string name, string contactNumber) : base(name, contactNumber)
        {
            trainingSchedule = false;
            activeBookings = new List<int>();
        }
        public string getContactInfo()
        {
            return name + " " + contactNumber;
        }
        public List<int> getActiveBookings()
        {
            return activeBookings;
        }
        public bool hasTrainingSchedule()
        {
            return trainingSchedule;
        }
        public void createBooking(/*facility, bookable object, key */) // bool
        {
            // TBA return bool value after booking is added to activeBookings for object
        }
        public void cancelBooking(/*facility, bookable object, key */) // bool
        {
            // TBA return bool value after cancellation of booking is completed
        }
    }
}
