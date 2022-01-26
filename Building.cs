using System;
using System.Collections.Generic;

namespace UrbanPlanner
{
    //Create Planner Class
    class Building
    {

         //Build a constructor for address
        public Building(string address) {
            _address = address;

        }
        //Private properties can only be accessed inside of class
        private string _designer = "Jordan"; 
        private DateTime _dateConstructed { get; set;}
        private string _address { get; set;}
        private string _owner { get; set;}

        //Public properties can be accessed outside of class
        public int Stories { get; set;}
        public double Width { get; set;}
        public double Depth { get; set;}
        
        //Make a read only class
        public double Volume {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
        public string Address {
            get
            {
                return _address;
            }
        }
        public string Designer {
            get
            {
                return _designer;
            }
        }
        public DateTime ConstructedDate {
            get
            {
                return _dateConstructed;
            }
        }
        public string Owner {
            get
            {
                return _owner;
            }
        }


        //Define public methods
        public void Construct() {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string owner) {
            _owner = owner;
        }

    };
    
}