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
        public void AddBookableRoom(int id, string type)
        {
            
            bookable.Add(new BookableRoom(id, type));
            
        }
        public void RemoveBookableRoom(int roomID)
        {
            
            bookable.RemoveAt(roomID);
            
        }
        public List<Bookable> GetBookableRooms()
        {
            return bookable;
        }

        public List<Dictionary<string, bool>> GetBookableHours()
        {        
            List<Dictionary<string, bool>> freeHours = new List<Dictionary<string, bool>>();               

            foreach (var item in bookable)
            {    
                Dictionary<string, bool> temp = new Dictionary<string, bool>();        
                foreach (var dict in ((BookableRoom)item).getSchedule())
                {
                   if (dict.Value == true)
                   {
                       temp.Add(dict.Key, dict.Value);
                   }
                }
                freeHours.Add(temp);
            }   
            
            return freeHours;       
        }
     
    }
}