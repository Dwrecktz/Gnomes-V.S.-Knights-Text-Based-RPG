using System;

namespace CSharp_Learning_Tutorial
{
    public class Gnome
    {
        public int EXP = 0;
        public int swatPoints = 2;
        public int healthPoints = 5;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Gnome gnome1 = new Gnome();

            Console.Write("Input Gnome Name: ");
            string input = Console.ReadLine();
            Console.WriteLine("Your Gnome name is: " + input);
            Console.WriteLine("Confirm? Y/N");
            string yesno = Console.ReadLine();

            switch (yesno)
            {
                case "Y":
                    Console.WriteLine("Ok!");
                    break;
                case "N":
                    Console.Clear();
                    Console.Write("Input Gnome Name: ");
                    string input2 = Console.ReadLine();
                    Console.WriteLine("Your Gnome name is: " + input2);
                    break;
                default:
                    Console.WriteLine("Not a valid choice!");
                    break;
            }

            Console.WriteLine("-----------------------");
            Console.WriteLine("Welcome to the world of Gnomes V.S. Knights! You are just starting on your journey, and you stumble onto a path.");
            Console.WriteLine("You have 2 decisions: Forest, or Castle (Castle gives more EXP). 1 = Forrest 2 = Castle (Goal is to get as much EXP as you can)");
            int choice1 = Convert.ToInt32(Console.ReadLine());

            switch (choice1)
            {
                case 1:
                    gnome1.EXP++;
                    Console.WriteLine("You continue on into the Forest!");
                    Console.WriteLine(input + " EXP: " + gnome1.EXP);
                    Console.WriteLine(input + " Swat Points: " + gnome1.swatPoints);
                    Console.WriteLine("Press Enter:");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("You stumble upon a knight! 1 = Attack 2 = Run away");
                    int playerchoice = Convert.ToInt32(Console.ReadLine());

                    if (playerchoice == 1 && gnome1.swatPoints > 0)
                    {
                        gnome1.EXP++;
                        gnome1.swatPoints--;
                        gnome1.healthPoints--;
                        Console.WriteLine("Knight beaten!");
                        Console.WriteLine(input + " EXP: " + gnome1.EXP);
                        Console.WriteLine(input + " Swat Points: " + gnome1.swatPoints);
                        Console.WriteLine(input + " Health Points: " + gnome1.healthPoints);
                        Console.WriteLine("Press enter:");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Regen? Y/N");
                        string input3 = Console.ReadLine();
                        if (input3 == "Y")
                        {
                            gnome1.EXP += 2;
                            gnome1.healthPoints = 5;
                            Console.WriteLine("Recharged!");
                            Console.WriteLine(input + " EXP: " + gnome1.EXP);
                            Console.WriteLine(input + " Swat Points: " + gnome1.swatPoints);
                            Console.WriteLine(input + " Health Points: " + gnome1.healthPoints);
                        }
                        else if (input3 == "N")
                        {
                            Console.WriteLine("You decided not to recharge!");
                        }
                    }
                    else if (playerchoice == 2 || gnome1.swatPoints <= 0)
                    {
                        Console.WriteLine("Ran away, or not enough Swat Points!");
                    }
                    Console.WriteLine("\nPress Enter: ");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("You continue on a path, but you come across a bunch of knights surrounded around a bonfire. Attack? Y/N");
                    string input4 = Console.ReadLine();
                    if (input4 == "Y")
                    {
                        Console.WriteLine("They all notice you, and there's 5 of them! Attack? Y/N");
                        string input5 = Console.ReadLine();
                        if (input5 == "Y")
                        {
                            Console.WriteLine("You attacked and defeated them all! Unfortunately, you got wounded severely, and died on your path home.");
                            Console.WriteLine("FINAL STATS:");
                            Console.WriteLine(input + " EXP: " + gnome1.EXP);
                            Console.WriteLine(input + " Swat Points: " + gnome1.swatPoints);
                            Console.WriteLine(input + " Health Points: " + gnome1.healthPoints);
                        }
                        else if (input5 == "N")
                        {
                            Console.WriteLine("You decided to not fight, and to try to find more knights. Unfortunately, you couldn't find anymore after searching for days, and decided to head home in fear that you would starve to death.");
                            Console.WriteLine("FINAL STATS:");
                            Console.WriteLine(input + " EXP: " + gnome1.EXP);
                            Console.WriteLine(input + " Swat Points: " + gnome1.swatPoints);
                            Console.WriteLine(input + " Health Points: " + gnome1.healthPoints);
                        }
                    }
                    break;

                case 2:
                    gnome1.EXP++;
                    Console.WriteLine("You continue on into the Castle!");
                    Console.WriteLine(input + " EXP: " + gnome1.EXP);
                    Console.WriteLine(input + " Swat Points: " + gnome1.swatPoints);
                    Console.WriteLine("Press Enter:");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("You stumble upon a merchant, and they offer you 5 swat points for 1 EXP! 1 = Buy 2 = Leave");
                    int playerchoice2 = Convert.ToInt32(Console.ReadLine());

                    if (playerchoice2 == 1 && gnome1.EXP > 0)
                    {
                        gnome1.EXP--;
                        gnome1.swatPoints += 5;
                        Console.WriteLine("Purchased Swat Points with EXP!");
                        Console.WriteLine(input + " EXP: " + gnome1.EXP);
                        Console.WriteLine(input + " Swat Points: " + gnome1.swatPoints);
                        Console.WriteLine(input + " Health Points: " + gnome1.healthPoints);
                        Console.WriteLine("Press enter:");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (playerchoice2 == 2)
                    {
                        Console.WriteLine("Decided not to buy Swat Points, and left.");
                        Console.WriteLine("Press Enter:");
                        Console.ReadKey();
                        Console.Clear();
                    }


                    Console.WriteLine("You continue down the main center of the castle, trying to stay low. A group of Knights spots you and starts charging after you. Attack? Y/N");
                    string input6 = Console.ReadLine();
                    if (input6 == "Y")
                    {
                        Console.WriteLine("They all notice you, and there's 5 of them! Attack? Y/N");
                        string input7 = Console.ReadLine();
                        if (input7 == "Y")
                        {
                            Console.WriteLine("You attacked and defeated them all! Unfortunately, you got wounded severely, and died on your path to the king's throne.");
                            Console.WriteLine("FINAL STATS:");
                            Console.WriteLine(input + " EXP: " + gnome1.EXP);
                            Console.WriteLine(input + " Swat Points: " + gnome1.swatPoints);
                            Console.WriteLine(input + " Health Points: " + gnome1.healthPoints);
                        }
                        else if (input7 == "N")
                        {
                            Console.WriteLine("You decided to not fight, and to try to flee. Unfortunately, they caught you, and were put in Gnome Jail.");
                            Console.WriteLine("FINAL STATS:");
                            Console.WriteLine(input + " EXP: " + gnome1.EXP);
                            Console.WriteLine(input + " Swat Points: " + gnome1.swatPoints);
                            Console.WriteLine(input + " Health Points: " + gnome1.healthPoints);
                        }
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
