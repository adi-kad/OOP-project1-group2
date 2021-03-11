using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    class Program
    {
        static void Main(string[] args)
        {
            Facility f1 = new Facility(1);
            var rooms = f1.GetBookableRooms();
            f1.AddBookableRoom(Role.Administrator, 1, "Spinning");
            f1.AddBookableRoom(Role.Administrator, 2, "Gruppaktiviter");
            f1.AddBookableRoom(Role.Administrator, 3, "Gruppaktiviter");
            f1.AddBookableRoom(Role.Administrator, 4, "Gruppaktiviter");
            f1.AddBookableRoom(Role.Administrator, 5, "Gruppaktiviter");

            // Get hours for all rooms
            foreach (var d in f1.GetBookableRooms())
            {
                foreach (var dict in ((BookableRoom)d).getSchedule())
                {
                    Console.WriteLine("Rum:" + d + " " + dict.Key + " " + dict.Value);
                }
            }
            // Get hours for specific room
            foreach(var dict in ((BookableRoom)rooms[0]).getSchedule() )
            {
                Console.WriteLine(dict.Key + " " + dict.Value);
            }

            f1.addNewEmployee(Role.Administrator,1,"Jesper","070000000");
            f1.addNewEmployee(Role.Administrator,2,"Olof","070000000");
            f1.addNewEmployee(Role.Receptionist,3,"Adnan","070000000");
            f1.addNewEmployee(Role.Receptionist,4,"Martin","070000000");
            f1.addNewEmployee(Role.Trainer,5,"Albin","070000000");

            
        }
    }
}
