using System;
using System.Collections.Generic;
using System.Text;

namespace COLLECTIONSEXAMPLES
{

    public class Person
    {

        public Person(string name)
        {
            _name = name;
        }

        private string _name;

        // Properties

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 3)
                {
                    _name = value;
                }
            }
        }


        public string Address { get; set; }


        // Functions (Methods)
        // -- Constructor

        // Fields
    }
}
