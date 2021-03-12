using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a facility class that we can use as a base for the system
            Facility f1 = new Facility(1);
            var rooms = f1.GetBookableRooms();

            // Create a administrator for the facility
            Administrator admin = new Administrator(1,"Olof","07000000");
            f1.AddNewEmployee(admin);

            // Create a room in the facility that can be booked for activities
            f1.AddBookableRoom(Role.Administrator,1,"Spinning");
            BookableRoom room1 = (BookableRoom)rooms[0];

            // Create a new bookable group activity by an administrator
            GroupActivity spinning = admin.addActivity(room1,DateTime.Parse("13:00"), DateTime.Parse("14:00"),null,"Spinning");

            // Returns all time slots for the room we just created. 
            // Also contains bool values if the room's time slots are bookable or not (true or false)
            foreach(var dict in (room1).getSchedule())
            {
                Console.WriteLine(dict.Key + " " + dict.Value);
            }

            // Creates a few test visitors
            Visitor v1 = new Visitor("Jesper", "0702392868");
            Visitor v2 = new Visitor("Adnan", "0703212321");

            // Add v1 & v2 to the group activity
            v1.joinGroupActivity(spinning);
            v2.joinGroupActivity(spinning);

            // Check all participants for the spinning activity
            foreach (var participants in spinning.getParticipants())
            {
                Console.WriteLine(participants.getContactInfo());
            }

            // Get all active bookings for v1 (visitor 1)
            foreach (var booking in v1.getActiveBookings())
            {
                Console.WriteLine(v1.getName());
                Console.Write(booking.getItem() + " ");
                Console.Write(booking.getStartTime() + " - ");
                Console.Write(booking.getEndTime());
            }
            Console.WriteLine();
            // Get all active bookings for v2 (visitor 2)
            foreach (var booking in v2.getActiveBookings())
            {
                Console.WriteLine(v2.getName());
                Console.Write(booking.getItem() + " ");
                Console.Write(booking.getStartTime() + " - ");
                Console.Write(booking.getEndTime());
            }
        }
    }
}
