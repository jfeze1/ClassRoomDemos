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

            private set
            {
                //The reserved key word "value" is used to optain the incoming data value to the property
                //save the incoming data value to your private data member
                _Sides = value;
            }
        }

        //Can be auto implemented
        //  Does not have a private data member
        //  The system creates an internal data storage member for the property
        // For the outside user, this property is now read only
        //Methods and code WITHIN the class have access to set
        public int FaceValue { get; private set; }

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
        }//eop (End Of Property)



        //CONSTRUCTORS
        //Costructors are NOT directly called byt the outside user
        //Constructors are called indirectly when the outside user creates an instance of the class
        //To create an instance of the class, the outside user will declare --> class variablename = new class();
        //it is the "new" that class the constructor

        //You may or may not a constructor for your class
        //If you do NOT code a constructor for your class then a default system constructor is executed
        //This default system constructor initializes your local data membersa to their default C# values

        //If you do code a constructor for your class  then YOU are responsible for all/any constructor in the class

        //"Default" constructor
        //This constructor is similar to the system constructor
        //  this constructor will be called for --> new classname();

        public Die()
        {
            //Even though the sides would be set to a valid numeric within this class, a more logical
            //  value would be 6
            Sides = 6;
            Color = "White";
            Roll();
        }

        //"Greedy" constructor
        //This constructor usually recieves a list of parameter, one for each data member in the class
        //The constructor takes the parameter values and assigns the value to the appropriate data member
        //This constructor would be called for --> new classname(value1, value2,...)
        //YOU CANNOT code the greedy constructor without the Default constructor

        public Die(int sides, string color)
        {
            Sides = sides; //the set{} of the property Sides is used
            Color = color;
        }


        //BEHAVIOURS
        //These are methods
        public void Roll()
        {
            //This method will be used to generate a new facevalue for the instance
            //an instance of the Math class Random() has been coded at the top of this class
            //The Method in the class Random() that will be called is .Next(inclusive lowest number, exclusive highest number)
            FaceValue = _rnd.Next(1, Sides + 1);
        }

        public void SetSides(int sides)
        {
            //let us assume only 6 to 20 sided dice are allowed
            if (sides > 5 && sides < 21)
            {
                Sides = sides;
                Roll();
            }
            else
            {
                //bad input
                throw new Exception("Invalid nuber of dice");
            }
        }
    }
}
