using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    class Facility 
    {
        private int id;
        private List<Bookable> bookable = new List<Bookable>();
        private List<Employee> employees = new List<Employee>();
        private List<Visitor> visitors = new List<Visitor>();

        public Facility(int id, List<Bookable> bookable, List<Employee> employees, List<Visitor> visitors)
        {
            this.id = id;
            this.bookable = bookable;
            this.employees = employees;
            this.visitors = visitors;
        }
        public Facility(int id)
        {
            this.id = id;
        }
        public void AddBookableRoom(Role role, int id, string type)
        {
            if(role == Role.Administrator)
            {
                bookable.Add(new BookableRoom(id, type));
            }
            else
            {
                Console.WriteLine("Du saknar behörighet att skapa ett nytt rum");
            }
        }
        public void RemoveBookableRoom(Role role,int roomID)
        {
            if(role == Role.Administrator)
            {
                bookable.RemoveAt(roomID);
            }
            else
            {
                Console.WriteLine("Du saknar behörighet att ta bort rum");
            }
        }
        public List<Bookable> GetBookableRooms()
        {
            return bookable;
        }
    }
}