using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    class Facility 
    {
         /* 
        location = physical gym location
        Facility class is the class that represent a gym location.
        Every locations needs a facility class as its the base everything else is built on
        Contains lists of every bookable object, employees and visitors
        Has methods that allows the administrator to add new employees to the location based on roles.
        */

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
      
        public List<Bookable> GetBookableRooms()
        {
            return bookable;
        }

        public bool AddNewEmployee(Role role, int id, string name, string contactNumber)
        {
            if(role == Role.Administrator)
            {
                employees.Add(new Administrator(id, name, contactNumber));
                return true;
            }
            else if(role == Role.Receptionist)
            {
                employees.Add(new Receptionist(id, name, contactNumber));
                return true;
            }
            else if(role == Role.Trainer)
            {
                employees.Add(new Trainer(id, name, contactNumber));
                return true;
            }
            return false;
        }
        public bool RemoveEmployee(Role role, int id, string name)
        {
            if(role == Role.Administrator)
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    if(id == employees[i].getEmployeeId() && name == employees[i].getEmployeeName())
                    {
                        employees.RemoveAt(i);
                        return true;
                    }
                }
            }
            else if(role == Role.Receptionist)
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    if(id == employees[i].getEmployeeId() && name == employees[i].getEmployeeName())
                    {
                        employees.RemoveAt(i);
                        return true;
                    }
                } 
            }
            else if(role == Role.Trainer)
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    if(id == employees[i].getEmployeeId() && name == employees[i].getEmployeeName())
                    {
                        employees.RemoveAt(i);
                        return true;
                    }
                } 
            }
            return false;
        }
        public void AddNewEmployee(Employee employee)
        {
            employees.Add(employee);  
        }
        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}