using System.Transactions;

namespace Topic_5___Asssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part1();

            //Part2();

            //Part3();
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
                    planetWeight = earthWeight


                }
                else if ((planetChoice == "2" || planetChoice.ToLower() == "mars"))
                {



                }
                else if ((planetChoice == "3" || planetChoice.ToLower() == "jupiter"))
                {



                }
                else if ((planetChoice == "4" || planetChoice.ToLower() == "saturn"))
                {



                }
                else if ((planetChoice == "5" || planetChoice.ToLower() == "uranus"))
                {



                }
                else if ((planetChoice == "6" || planetChoice.ToLower() == "neptune"))
                {



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



        }

        public static void Part3()
        {



        }


    }
}
