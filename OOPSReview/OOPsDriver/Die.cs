using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDriver
{

    //Classes by default have a access privilege of private
    //you MUST add public to your classes
    public class Die
    {
        //create a new instance of the math object random
        //This will be shared by each instance of Die
        //The instance of Random object will be created when
        //the first instance of Die is created
        private static Random _rnd = new Random();

        //Classes have four basic things
        // a) Data members
        // b) Properties
        // c) Constructors
        // d) Behaviours(methods)

        //Data members may be private for the class for use only within the class

        //The interface with a class is done via properties and behaviours

        //Properties
        //Can be fully implemented
        // - a private data member
        // - a public property

        private int _Sides;
        public int Sides
        {
            get
            {
                //this will return the private data member
                return _Sides;
            }

            set
            {
                //The reserved key word "value" is used to optain the incoming data value to the property
                //save the incoming data value to your private data memeber
                _Sides = value;
            }
        }

        //Can be auto implemented
        //  Does not have a private data member
        //  The system creates an internal data storage member for the property
        public int FaceValue { get; set; }

        //Within a property, you can validate the incoming data value is "what is expected"
        private string _Color;
        public string Color
        {
            get
            {
                return _Color;
            }
            set
            {
                //SAMPLE VALIDATION
                //There MUST be data within the incoming value. So an empty string is invalid
                if (string.IsNullOrEmpty(value))
                {
                    //incoming data value is incorrect
                    // a) you could send an error message to the outside user
                    //throw new Exception("Color must have a value");

                    //OR

                    // b) you could allow the storage of a null value within the string data member (case of nullable field in the database)
                    _Color = null;
                }
                else
                {
                    _Color = value;
                }
            }
        }
    }
}
