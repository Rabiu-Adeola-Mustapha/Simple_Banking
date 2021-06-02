using System;

namespace Bank_Functtion
{
    class Program
    {

        static int userOption { get; set; }
        static int availableBalance { get; set; }
        

        //Bank bdepo = new Bank();
        

        public static void Main(string[] args)
        {

                 //User types in their name and gets a welcome note
                 Bank.Welcome();
            do 
            { 

                //User decides his prefered transactions.
                Bank b = new Bank();
            
                int userChoice = b.MainMenu();

                

                b.Banking(userChoice, availableBalance);

                

                userOption = Bank.Decision();

            } while (userOption == 1);

            Console.WriteLine("Thank you for Banking with MayMoon Bank. \n Do have a lovely day.");

        }
    }

    public class Bank
    {
        
        public int userChoice { set; get; }
        static int availableBalance { get; set; }
        static int decision { set; get; }


        public static void Welcome()
        {


            Console.WriteLine("Please enter your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + ".");


        }
        public int MainMenu()
        {

            do
            {
                Console.WriteLine(" please press 1 - To Deposit, Press 2 - Withdraw, Press 3 - To buy Airtime, Press 4 - To check Balance");
                userChoice = int.Parse(Console.ReadLine());

            } while (userChoice != 1 && userChoice != 2 && userChoice != 3 && userChoice != 4);

            return userChoice;
        }

        public int Deposit()
        {

            Console.WriteLine("How much would like to deposit?");
            int deposit = int.Parse(Console.ReadLine());
            return availableBalance = +deposit;



        }

        public int Withdraw()
        {

            Console.WriteLine("Enter the amount you want to withdraw");
            int WithdrawAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("The amount you want to withdraw is {0} \n Press 1 - To countine. Press 0 - Cancel", WithdrawAmount);
            int decide = int.Parse(Console.ReadLine());

            switch (decide)
            {
                case 1:
                    if (availableBalance >= WithdrawAmount)
                    {
                        Console.WriteLine("Transaction Suceessful");
                        Console.WriteLine("Your available balance is {0}", availableBalance - WithdrawAmount);
                        return availableBalance;
                    }
                    else
                    {
                        Console.WriteLine("Insufficient account balance");
                    }

                    break;

                case 0:
                    break;
            }

            return availableBalance;

        }

        public int ByAirtime()
        {

            Console.WriteLine("Enter the Airtime amount you want to buy");
            int AirtimeAmount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Phone Number you want to recharge");
            string PhoneNum = Console.ReadLine();

            Console.WriteLine("The Airtime amount you want to buy is {0} and the Phone Number is {1}" +
                " \n Press 1 - To countine. Press 0 - Cancel", AirtimeAmount, PhoneNum);
            int decide = int.Parse(Console.ReadLine());

            switch (decide)
            {
                case 1:
                    if (availableBalance >= AirtimeAmount)
                    {
                        Console.WriteLine("Transaction Suceessful");
                        Console.WriteLine("Your available balance is {0}", availableBalance = availableBalance - AirtimeAmount);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient account balance");
                    }



                    break;

                case 0:
                    break;

                   
            }

            return availableBalance;



        }

        public void CheckBalance()
        {
            Console.WriteLine("Your Available Balance is {0}", availableBalance);

            
        }


        public static int Decision()
        {
            Console.WriteLine("Press 1 - To go back to main menu \n Press 0 - To end transaction.");
            int userOption = 0;
            do
            {

                string value = Console.ReadLine();

                if (int.TryParse(value, out userOption))
                {
                    int.TryParse(value, out userOption);
                }
                else
                {
                    userOption = 7;
                    Console.WriteLine("You can only choose 1 or 0");
                }

                //else if (userOption == 0)
                //{
                //    Console.WriteLine("Thank you for Banking with MayMoon Bank. \n Do have a lovely day.");
                //    return 0;
                //}

            } while (userOption != 1 && userOption != 0);

            return userOption;
        }
          
        public int Banking(int userChoice, int availableBalance)
        {

            if (userChoice == 1)
            {
                Bank b1 = new Bank();
                b1.Deposit();

            }

            if (userChoice == 2)
            {
                Bank b2 = new Bank();
                b2.Withdraw();
            }

            if (userChoice == 3)
            {
                Bank b3 = new Bank();
                b3.ByAirtime();
            }

            if (userChoice == 4)
            {
                Bank b4 = new Bank();
                b4.CheckBalance();
            }

            return availableBalance;
        }
    }
}
