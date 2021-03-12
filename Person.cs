using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    abstract class Person
    {
        /* 
        Base class for any subclass that will handle humans in the system
        Contains the name and cellphone number of every object.
        */

        protected string name, contactNumber;

        public Person(string name, string contactNumber)
        {
            this.name = name;
            this.contactNumber = contactNumber;
        }
        
        //Send a message *to* this Person
        public void sendMessage(string text)
        {
            //NYI
        }
    }
}
