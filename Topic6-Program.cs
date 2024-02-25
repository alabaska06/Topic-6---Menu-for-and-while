namespace Topic_6___Menu__for_and_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            while (choice != "q")
            {
                Console.Clear(); 
                Console.WriteLine("Welcome to my menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Prompter");
                Console.WriteLine("2 - PercentPassing");
                Console.WriteLine("3 - OddSum"); 
                Console.WriteLine("4 - Random Numbers");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1") //prompter
                {
                    Console.WriteLine("You chose Prompter.");

                    int min, max, middle;

                    Console.WriteLine("Please type a number below, this will be your minimum:");
                    min = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Please type a number bigger than {min}, this will be your maximum:");
                    max = Convert.ToInt32(Console.ReadLine());

                    while (max < min)
                    {
                        Console.WriteLine($"Your maximum cannot be smaller than {min}. Please choose again:");
                        max = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.WriteLine($"Thank you. Please type a number in between {min} and {max} below:");
                    middle = Convert.ToInt32(Console.ReadLine());

                    while (middle > max || middle < min)
                    {
                        Console.WriteLine($"That is not within {min} and {max}. Please choose a new number:");
                        middle = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Thanks for choosing a number in between {min} and {max}.");

                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "2")//percentpassing
                {
                    Console.WriteLine("You chose PercentPassing");

                    int numScores, scoresAbove70;
                    double percentageAbove70;
                    scoresAbove70 = 0;
                    Console.Write("How many scores would you like to enter?");
                    numScores = int.Parse(Console.ReadLine());

                    for (int i = 0; i < numScores; i++)
                    {
                        Console.Write($"Enter score {i + 1}: ");
                        int score = int.Parse(Console.ReadLine());

                        if (score > 70)
                        {
                            scoresAbove70++;
                        }
                    }

                    percentageAbove70 = (double)scoresAbove70 / numScores * 100;

                    Console.WriteLine($"Percentage of scores above 70: {percentageAbove70}%");

                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "3")//Odd sum
                {
                    Console.WriteLine("You chose OddSum");

                    int max, sum;
                    sum = 0;
                    Console.WriteLine("Please choose a number:");
                    max = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= max; i += 2)
                    {
                        sum += i;
                    }
                    Console.WriteLine($"The sum of all odd numbers up to {max} is {sum}");

                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "4") //random numbers
                {
                    Console.WriteLine("You chose Random Numbers");

                    Random generator = new Random();
                    int min, max;

                    Console.WriteLine("Please type a number below, this will be your minimum:");
                    min = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Please type a number bigger than {min}, this will be your maximum:");
                    max = Convert.ToInt32(Console.ReadLine());

                    while (max < min)
                    {
                        Console.WriteLine($"Your maximum cannot be smaller than {min}. Please choose again:");
                        max = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.WriteLine($"Thank you. Here are 25 random numbers in between {min} and {max}.");
                    for (int i = 1; i <= 25; i++) 
                    {
                        int number = generator.Next(min, max);// this wont fucking work for what ever reason ugh 
                    }

                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "q")
                {
                    Console.WriteLine("Thanks for playing.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }
        }
    }
}
