using System.Runtime.CompilerServices;

namespace Topic_5___Making_an_new_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int i = 1;
            double betChoice, userBet, account;
            account = 100;
            

            Console.WriteLine("Welcome to my dice game!");

            while (i < 10)
            {
            Console.WriteLine($"\nIn this game you will bet on the probability of two die. Your account balance is ${account}");
            Console.WriteLine();
            Console.WriteLine("Here are your options:");
            Console.WriteLine();
            Console.WriteLine("1. Doubles - Dice roll doubles, you win double your bet. Dice don't roll doubles, you lose double your bet.");
            Console.WriteLine();
            Console.WriteLine("2. Not doubles - Dice doesn't roll doubles, you win your bet. Dice roll doubles, you lose your bet.");
            Console.WriteLine();
            Console.WriteLine("3. Even sum - Dice total is an even sum, you win your bet. Dice total is an odd sum, you lose your bet.");
            Console.WriteLine();
            Console.WriteLine("4. Odd sum - Dice total is an odd sum, win your bet. Dice total is an even sum you lose your bet.");
            Console.WriteLine();
            Console.WriteLine("5. Quit Game");
            Console.WriteLine();
            Console.WriteLine("Please type your corresponding bet number below:");
            Console.WriteLine();
            betChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPlease type the amount you'd like to bet below:");
            Console.WriteLine();
            userBet = Convert.ToInt32(Console.ReadLine());

            if (account > 0)
                {
                    Console.WriteLine("Sadly you are out of money! Better luck next time.");//does the loop stop?
                }

            if (userBet > account)
            {
                Console.WriteLine($"\nYou bet more than your account balance. Your bet is now ${account}");
                userBet = account;
            }
            else if (userBet < 0)
            {
                Console.WriteLine("\nThat is an invalid bet. \n\nPlease type a new bet below:");
                userBet = Convert.ToInt32(Console.ReadLine()) ;
            }

            Die die1 = new Die();
            Die die2 = new Die();
            Console.WriteLine();
            Console.WriteLine("Here is your roll:");
            
            die1.DrawRoll();
            die2.DrawRoll();

                if (die1.Roll == die2.Roll)
                {
                    DisplayBets(betChoice);

                    void DisplayBets(double betChoice)
                    {
                        switch (betChoice)
                        {
                            case (1):
                                Console.WriteLine();
                                Console.WriteLine("\nThat's correct, the dice rolled doubles! \n\nYour bet has been doubled and added to your sum!");
                                account = (userBet * 2) + account;
                                Console.WriteLine($"\nAccount Balance: {account}");
                                break;
                            default:
                                Console.WriteLine();
                                Console.WriteLine("\nThat's incorrect.\n\nDouble your bet has been removed from your sum.");
                                account = account - (userBet * 2);
                                Console.WriteLine($"\nAccount Balance: {account}");
                                break;
                        }
                    }
                }
                else if ((die1.Roll + die2.Roll) % 2 == 0)
                {
                    DisplayBets(betChoice);

                    void DisplayBets(double betChoice)
                    {
                        switch (betChoice)
                        {
                            case (3):
                                Console.WriteLine();
                                Console.WriteLine("\nThat's correct, the dice sum is even! \n\nYou win your bet!");
                                account = userBet + account;
                                Console.WriteLine($"\nAccount Balance: {account}");
                                break;
                            case (2):
                                Console.WriteLine();
                                Console.WriteLine("\nThat's correct, the dice did not roll doubles! \n\nYou win your bet!");
                                account = userBet + account;
                                Console.WriteLine($"Account Balance: {account}");
                                break;
                            default:
                                Console.WriteLine();
                                Console.WriteLine("\nThat's incorrect.\n\nYou lose your bet.");
                                account = account - userBet;
                                Console.WriteLine($"\nAccount Balance: {account}");
                                break;
                        }
                    }
                }
                else if ((die1.Roll + die2.Roll) % 2 != 0)
                {
                    DisplayBets(betChoice);

                    void DisplayBets(double betChoice)
                    {
                        switch (betChoice)
                        {
                            case (4):
                                Console.WriteLine();
                                Console.WriteLine("\nThat's correct, the dice sum is odd! \n\nYou win your bet!");
                                account = userBet + account;
                                Console.WriteLine($"\nAccount Balance: {account}");
                                break;
                            case (2):
                                Console.WriteLine();
                                Console.WriteLine("\nThat's correct, the dice did not roll doubles! \n\nYou win your bet!");
                                account = userBet + account;
                                Console.WriteLine($"Account Balance: {account}");
                                break;
                            default:
                                Console.WriteLine();
                                Console.WriteLine("\nThat's incorrect.\n\nYou lose your bet.");
                                account = account - userBet;
                                Console.WriteLine($"\nAccount Balance: {account}");
                                break;
                        }
                    }
                }
                else if (userBet == 5)//added a way to quit
                {
                    Console.WriteLine("Thanks for playing");//does the loop stop?
                }
            }
        }
    }
}