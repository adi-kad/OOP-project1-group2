using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    abstract class Bookable
    {
        private int id;
        private Dictionary<string,bool> hours;
        private string type;

        //Bookable times
        public Bookable(int id, string type) 
        {
            hours = new Dictionary<string,bool>();
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
        }          
    }
}
