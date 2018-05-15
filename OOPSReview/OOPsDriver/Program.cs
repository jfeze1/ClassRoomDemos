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

                            //Roll the dice for each player
                            //The dot operator is used with your instance to acess a property or a behaviour
                            Player1Dice.Roll();
                            Player2Dice.Roll();

                            //Record the results of the roll for this turn
                            //we need to create a new instance of the Turn class
                            Turn aturn = new Turn();

                            //assign the facevalue of each dice to the Turn instance

                            //         set                      get
                            aturn.Player1DiceValue = Player1Dice.FaceValue;
                            aturn.Player2DiceValue = Player2Dice.FaceValue;

                            //Determine your battle results
                            //It does not matter in this logic wether we use the values from aturn or the Die variables
                            if (aturn.Player1DiceValue > Player2Dice.FaceValue)
                            {
                                aturn.TurnWinner = "Player1";
                            }
                            else if (aturn.Player2DiceValue > aturn.Player1DiceValue)
                            {
                                aturn.TurnWinner = "Player2";
                            }
                            else
                            {
                                aturn.TurnWinner = "Draw";
                            }
                            //Display the dresults to the user
                            Console.WriteLine("results: Player1 rolled {0} Player2 rolled {1} Winner: {2} ", aturn.Player1DiceValue, aturn.Player2DiceValue, aturn.TurnWinner);

                            //Add the turn instance to the List<T>
                            gameTurn.Add(aturn);
                            break;
                        }
                    case "C":
                        {
                            //Display the current standing in the game
                            //foreach loop
                            //This loop will start processing your collection from the first instance to the last instance moving automatically to the next instance

                            //C# will strongly datatype variable at compile time when the datatype is used in declaring the variable
                            //C# also has a datatype called "var".
                            //var datatype is set at execution time but is still strongly datatype on its FIRST execution
                            foreach(var thisTurn in gameTurn)
                            {
                                Console.WriteLine("results: Player1 rolled {0} Player2 rolled {1} Winner: {2} ", thisTurn.Player1DiceValue, thisTurn.Player2DiceValue, thisTurn.TurnWinner);
                            }
                            Console.WriteLine("\n");
                            break;
                        }
                    case "X":
                        {

                            int player1wins = 0, player2wins = 0, draws = 0;
                            Console.WriteLine("Thank you for playing. Come again.");

                            foreach(var wins in gameTurn)
                            {
                                if(wins.Player1DiceValue > wins.Player2DiceValue)
                                {
                                    player1wins++;
                                }
                                else if (wins.Player2DiceValue > wins.Player1DiceValue)
                                {
                                    player2wins++;
                                }
                                else
                                {
                                    draws++;
                                }
                            }

                            Console.WriteLine("Player1 has: {0} \n Player2 has: {1} \n Draws: {2}", player1wins, player1wins, draws);
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
