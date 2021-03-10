using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    class Facility 
    {
        private int id;

        //private List<Bookable> bookable = new List<Bookable>();

        //private List<Employee> employees = new List<Employee>();
        private List<Visitor> visitors = new List<Visitor>();

        public Facility(int id, List<Visitor> visitors)
        {
            this.id = id;
            this.visitors = visitors;
        }
        public void AddBookableRoom()
        {
            /*
            bookable.Add();
            */
        }
        public void RemoveBookableRoom(int roomID)
        {
            /*
            bookable.Remove(roomID);
            */
        }
        /*public List<Bookable> GetBookableRooms()
        {
            return bookable
        }*/
    }
}