using System.Transactions;

namespace Topic_5___Asssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this is the trvais assignment

            //Part1();

            //Part2();

            Part3();
        }

        public static void Part1()
        {
            double earthWeight, planetWeight;
            string planetChoice;

            Console.WriteLine("What is your weight (lbs) on Earth?");
            if (double.TryParse(Console.ReadLine(), out earthWeight))
            {
                Console.WriteLine("");
                Console.WriteLine("You weigh " + earthWeight + "lbs on Earth. Pick a planet for your weight on that planet.");
                Console.WriteLine("1. Venus \t" + "2. Mars \t" + "3. Jupiter");
                Console.WriteLine("4. Saturn \t" + "5. Uranus \t" + "6. Neptune");
                Console.Write("Answer here: ");
                planetChoice = Console.ReadLine();
                Console.WriteLine("");

                if ((planetChoice == "1" || planetChoice.ToLower() == "venus"))
                {
                    planetWeight = earthWeight * .78;
                    Console.WriteLine("You would weigh " + planetWeight + "lbs on Venus.");

                }
                else if ((planetChoice == "2" || planetChoice.ToLower() == "mars"))
                {
                    planetWeight = earthWeight * .39;
                    Console.WriteLine("You would weigh " + planetWeight + "lbs on Mars.");


                }
                else if ((planetChoice == "3" || planetChoice.ToLower() == "jupiter"))
                {
                    planetWeight = earthWeight * 2.65;
                    Console.WriteLine("You would weigh " + planetWeight + "lbs on Jupiter.");


                }
                else if ((planetChoice == "4" || planetChoice.ToLower() == "saturn"))
                {
                    planetWeight = earthWeight * 1.17;
                    Console.WriteLine("You would weigh " + planetWeight + "lbs on Saturn.");


                }
                else if ((planetChoice == "5" || planetChoice.ToLower() == "uranus"))
                {
                    planetWeight = earthWeight * 1.05;
                    Console.WriteLine("You would weigh " + planetWeight + "lbs on Uranus.");


                }
                else if ((planetChoice == "6" || planetChoice.ToLower() == "neptune"))
                {
                    planetWeight = earthWeight * 1.23;
                    Console.WriteLine("You would weigh " + planetWeight + "lbs on Neptune.");


                }
                else
                {
                    Console.WriteLine("ERROR! Invalid input. Restart the program.");
                }


            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("ERROR! Invalid input. Restart the program.");
            }

        }

        public static void Part2()
        {
            double firstNumber, secondNumber, resultNumber;
            string symbol; 

            Console.WriteLine("Provide a number.");
            if (double.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.WriteLine("");
                Console.WriteLine("Provide another number.");
                if (double.TryParse(Console.ReadLine(), out secondNumber))
                {
                    Console.WriteLine("");
                    Console.WriteLine("Provide a symbol. (+, -, /, *)");
                    symbol = Console.ReadLine();
                    Console.WriteLine("");
                    if (symbol == "+")
                    {
                        resultNumber = firstNumber + secondNumber;
                        Console.WriteLine("Your resulting number is " + resultNumber + ".");
                    }
                    else if (symbol == "-")
                    {
                        resultNumber = firstNumber - secondNumber;
                        Console.WriteLine("Your resulting number is " + resultNumber + ".");
                    }
                    else if (symbol == "*")
                    {
                        resultNumber = firstNumber * secondNumber;
                        Console.WriteLine("Your resulting number is " + resultNumber + ".");
                    }
                    else if (symbol == "/")
                    {
                        resultNumber = firstNumber / secondNumber;
                        Console.WriteLine("Your resulting number is " + resultNumber + ".");
                    }
                    else
                    {
                        Console.WriteLine("ERROR! Invalid input. Restart the program.");
                    }


                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("ERROR! Invalid input. Restart the program.");
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("ERROR! Invalid input. Restart the program.");
            }
        }

        public static void Part3()
        {
            int points = 0;
            string question1, question2, question3, question4;

            Console.WriteLine("QUIZ TIME!!!! To answer properly, YOU gotta type out the answer's number, not the answer itself!");
            Console.WriteLine("");
            Console.WriteLine("First Question! When did the Western Roman Empire fall?");
            Console.WriteLine("1: 330 AD");
            Console.WriteLine("2: 476 AD");
            Console.WriteLine("3: 1453 AD");
            Console.WriteLine("4: 1066 AD");
            Console.WriteLine("");
            question1 = Console.ReadLine();
            Console.WriteLine("");
            if (question1 == "1")
            {
                Console.WriteLine("Nope! Later than that! No points.");
            }
            else if (question1 == "2")
            {
                Console.WriteLine("CORRECT!!! You get a point!");
                points += 1;
            }
            else if (question1 == "3")
            {
                Console.WriteLine("Not even CLOSE! No points.");
            }
            else if (question1 == "4")
            {
                Console.WriteLine("Way earlier than that! No points.");
            }
            else
            {
                Console.WriteLine("No no NO! That's not an answer! You're getting points docked.");
                points -= 1;
            }
            Console.WriteLine("");

        }


    }
}
