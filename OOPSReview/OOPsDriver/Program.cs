using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the instances of our objects to be used in this program

            //You can check for additional namespaces that may be needed to use your objects.

            //we need to have a structure that will allow one to hold an unknown number of instances of a variable
            //List<T> is an object that hold x number of datatype instances 
            //the new List<T> phisical creates the instance of List<T> in memory. the constructor of List is called
            List<Turn> gameTurn = new List<Turn>();

            //Create  2 instances of the Die object
            Die Player1Dice = new Die();      //Default constructor
            Die Player2Dice = new Die(6, "Green");




            string menuChoice = "";
            do
            {
                Console.WriteLine("Game Menu: \n");
                Console.WriteLine("A) Set Die side count");
                Console.WriteLine("B) Roll the dice");
                Console.WriteLine("C) Display all game turn results");
                Console.WriteLine("X) Exit");
                Console.Write("Enter menu choice: ");
                menuChoice = Console.ReadLine();

                switch (menuChoice.ToUpper())
                {
                    case "A":
                        {
                            //logic can de done using a method
                            //the method will need to have the local variables player1Dice and player2Dice passed to it
                            //Objects are passed as references
                            SetDiceSides(Player1Dice, Player2Dice);

                            break;
                        }
                    case "B":
                        {
                            //logic can be done actually inside the case
                            //one does not have to always call a method

                            Console.WriteLine("You selected B");
                            break;
                        }
                    case "C":
                        {
                            Console.WriteLine("You selected C");
                            break;
                        }
                    case "X":
                        {
                            Console.WriteLine("Thank you for playing. Come again.");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid menu choice. Try again.");
                            break;
                        }

                }
            } while (menuChoice.ToUpper() != "X");
            Console.ReadKey();
        }

        public static void SetDiceSides(Die player1dice, Die player2dice)
        {
            string indicesize = "";
            int dicesize = 6;

            Console.WriteLine("Set dice face count of 6 to 20");
            Console.WriteLine("An invalid entry will default to 5");
            Console.Write("Enter numbe of sides: ");
            indicesize = Console.ReadLine();

            //Validation
            //a) did the user enter a number
            if(!int.TryParse(indicesize, out dicesize))
            {
                Console.WriteLine("Die size is invalid. Die size size will be set to 6");
                dicesize = 6;
            }
            else
            {
                //b) is interger between 6 and 20
                if(dicesize < 6 || dicesize > 20)
                {
                    Console.WriteLine("Die size is invalid. Die size size will be set to 6");
                    dicesize = 6;
                }
                else
                {
                    Console.WriteLine("Die size will be set to {0}", dicesize);
                }
            }
            player1dice.SetSides(dicesize);
            player2dice.SetSides(dicesize);
        }
    }
}
