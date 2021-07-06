using System;

namespace ConsoleApp1Vending_Machine
{
    // Interface
    interface IVending
    {
        void Purchase(int pur); // interface method (does not have a body                     
        void ShowAll(int show);  // interface method (does not have a body)

        /*
        void InsertMoney(); // interface method (does not have a body)
        void EndTransaction(); // interface method (does not have a body)
        */
    }

    // Pig "implements" the IAnimal interface
    class ClassPurchase : IVending
    {
        public void Purchase(int pur)
        {
            if (pur == 1)
            {
                // The body of animalSound() is provided here
                Console.WriteLine(" Eat the apple. ");
            }
            else if (pur == 2)
            {
                // The body of animalSound() is provided here
                Console.WriteLine(" Eat the orange. ");
            }
            else if (pur == 3)
            {
                // The body of animalSound() is provided here
                Console.WriteLine(" Eat the banana. ");
            }
        }

        public void ShowAll(int pur)
        {
            double[] mySums = { 1, 5, 10, 20, 50, 100, 500, 1000 };
            if (pur == 1)
            {
                // The body of animalSound() is provided here
                Console.WriteLine(" Eat the apple. ");
            }
            else if (pur == 2)
            {
                // The body of animalSound() is provided here
                Console.WriteLine(" Eat the orange. ");
            }
            else if (pur == 3)
            {
                // The body of animalSound() is provided here
                Console.WriteLine(" Eat the banana. ");
            }
        }

    }





    class Program
    {
        static void Main(string[] args)
        {
            bool keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.WriteLine("--------------------------------------------------- ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Choose what product you want and how many of them.\n " +
                                        "1. Apple.  2. Orange.  3. Banana.  ('0' End program)");
                    int assignmentChoice = int.Parse(Console.ReadLine() ?? "");                   
                    Console.WriteLine("--------------------------------------------------- ");

                    switch (assignmentChoice)
                    {
                        case 1:

                            ClassPurchase myPurchase1 = new ClassPurchase();  // Create  object
                            int pur1 = 1;
                            myPurchase1.Purchase( pur1 );

                            break;//----------------------------------------------

                        case 2:

                            ClassPurchase myPurchase2 = new ClassPurchase();  // Create  object
                            int pur2 = 2;
                            myPurchase2.Purchase(pur2);

                            break;//-----------------------------------------------

                        case 3:

                            ClassPurchase myPurchase3 = new ClassPurchase();  // Create  object
                            int pur3 = 3;
                            myPurchase3.Purchase(pur3);

                            break;//-------------------------------------------------







                        case 0:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" 1. That is not a valid input!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine(" Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" 2. That is not a valid input!");
                    Console.ResetColor();
                }

            }//while (keepAlive)




            



            }
    }
}
