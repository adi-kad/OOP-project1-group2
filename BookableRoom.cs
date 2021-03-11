using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    class BookableRoom : Bookable
    {
        //Bookable times
        public BookableRoom(int id, string type) : base(id, type)
        {
			
        }
        public override string ToString()
        {
            return id.ToString() + " " + type;
        }
        public Dictionary<string, bool> getSchedule()
        {
            return hours;
        }

    }
}
