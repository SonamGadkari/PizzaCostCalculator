using System;

namespace PizzaCostCalculator
{
    class Program
    {
        public decimal totCost(string baseV, string topp, string cheese)
        {
            decimal totalCost = 0.0m;
            if (baseV == "Flatbread")
            {
                totalCost = totalCost + 3.2m;
            }
            else
            {
                totalCost = totalCost + 5;
            }

            switch (cheese)
            {
                case "Mozzarella":
                case "Fresh Cheese":
                    totalCost = totalCost + 2.5m;
                    break;
                case "Cheddar Cheese":
                    totalCost = totalCost + 3;
                    break;
                case "Swiss Cheese":
                    totalCost = totalCost + 4;
                    break;
            }

            if (topp == "Chicken and Fish" | topp == "Sausage" | topp == "Bacon")
            {
                totalCost = totalCost + 7;
            }
            else if (topp == "Capsicum and Golden corn" | topp == "Onion and mushroom" | topp == "Pepperoni")
            {
                totalCost = totalCost + 4;
            }

            return totalCost;
        }

        static void Main(string[] args)
        {
            string customername = "";
            string PizzaBase = "";
            bool quitOption = false;
            string cheeseType = "";
            int baseoption = 0;
            int toppinoption;
            int cheeseoption;
            decimal PizzaCost;
            string toppin = "";
            double tax;
            double totalCost;
            DateTime now = DateTime.Now;
            
            do
            {
                do
                {
                    Console.WriteLine("\nHi!\nEnter your name:");
                    customername = Console.ReadLine();
                } while (customername == "");
                Console.WriteLine("\n");
                do
                {
                    Console.WriteLine("Enter the option of Pizza base from the following menu");
                    Console.WriteLine("\n\t\t 1.Flatbread");
                    Console.WriteLine("\n\t\t 2.Thin Crust");
                    Console.WriteLine("\n\t\t 3.Sicilian Style");
                    Console.WriteLine("\n\t\t 4.Pizza Bagels");
                    baseoption = Convert.ToInt32(Console.ReadLine());
                } while (baseoption > 5 && baseoption < 0);

                if (baseoption == 1)
                {
                    Console.WriteLine($"\n Your selection is {baseoption}. Flatbread");
                    PizzaBase = "Flatbread";
                }
                else if (baseoption == 2)
                {
                    Console.WriteLine($"\n Your selection is {baseoption}. Thin Crust");
                    PizzaBase = "Thin Crust";
                }
                else if (baseoption == 3)
                {
                    Console.WriteLine($"\n Your selection is {baseoption}. Sicilian Style");
                    PizzaBase = "Sicilian Style";
                }
                else if (baseoption == 4)
                {
                    Console.WriteLine($"\n Your selection is {baseoption}. Pizza Bagels");
                    PizzaBase = "Pizza Bagels";
                }
                Console.WriteLine("\n");
                do
                {
                    Console.WriteLine("Would you like to add some toppings?? ");
                    Console.WriteLine("Enter your option from below");
                    Console.WriteLine("\n\t 0.None \n\t 1.Capsicum and Golden corn\n\t 2.Onion and mushroom \n\t 3.Chicken and Fish\n\t 4.Sausage\n\t 5.Bacon\n\t 6.Pepperoni");
                    toppinoption = Convert.ToInt32(Console.ReadLine());

                } while (toppinoption < 0 || toppinoption > 6);

                if (toppinoption == 1)
                {
                    Console.WriteLine($"\n Your selection is {toppinoption}. Capsicum and Golden corn");
                    toppin = "Flatbread";
                }
                else if (toppinoption == 2)
                {
                    Console.WriteLine($"\n Your selection is {toppinoption}. Onion and mushroom");
                    toppin = "Thin Crust";
                }
                else if (toppinoption == 3)
                {
                    Console.WriteLine($"\n Your selection is {toppinoption}. Chicken and Fish");
                    toppin = "Sicilian Style";
                }
                else if (toppinoption == 4)
                {
                    Console.WriteLine($"\n Your selection is {toppinoption}. Sausage");
                    toppin = "Sausage";
                }
                else if (toppinoption == 5)
                {
                    Console.WriteLine($"\n Your selection is {toppinoption}. Bacon");
                    toppin = "Bacon";
                }
                else if (toppinoption == 6)
                {
                    Console.WriteLine($"\n Your selection is {toppinoption}. Pepperoni");
                    toppin = "Pepperoni";
                }
                else if (toppinoption == 0)
                {
                    Console.WriteLine($"\n Your selection is {toppinoption}. No toppings");
                    toppin = "n";
                }
                Console.WriteLine("\n");
                do
                {
                    Console.WriteLine("Enter your option from below for type of cheese");
                    Console.WriteLine("\n\t 1.Mozzarella\n\t 2.Cheddar Cheese \n\t 3.Fresh Cheese\n\t 4.Swiss Cheese");
                    cheeseoption = Convert.ToInt32(Console.ReadLine());
                } while (cheeseoption > 4 | cheeseoption < 0);
                Console.WriteLine("\n");
                switch (cheeseoption)
                {
                    case 1:
                        Console.WriteLine($"\n Your selection is {cheeseoption}. Mozzarella");
                        cheeseType = "Mozzarella";
                        break;
                    case 2:
                        Console.WriteLine($"\n Your selection is {cheeseoption}. Cheddar Cheese");
                        cheeseType = "Cheddar Cheese";
                        break;
                    case 3:
                        Console.WriteLine($"\n Your selection is {cheeseoption}. Fresh Cheese");
                        cheeseType = "Fresh Cheese";
                        break;
                    case 4:
                        Console.WriteLine($"\n Your selection is {cheeseoption}. Swiss Cheese");
                        cheeseType = "Swiss Cheese";
                        break;
                    default:
                        break;

                }
                Console.WriteLine("\n");
                Program total = new Program();
                PizzaCost = total.totCost(PizzaBase, toppin, cheeseType);
                tax=Convert.ToDouble(0.10m*PizzaCost);
                totalCost=Convert.ToDouble(PizzaCost)+tax;
                Console.WriteLine("\n*********************************************************");
                Console.WriteLine("******************Order Information**********************");
                Console.WriteLine($"Order Date: {now.ToString("dd/MM/yyyy")}");
                Console.WriteLine($"Order : {PizzaBase} Pizza with {cheeseType} topped with {toppin}");
                Console.WriteLine($"Order total:\t {PizzaCost}$");
                Console.WriteLine($"Tax levied:\t {tax}$");
                Console.WriteLine($"Order total:\t {totalCost}$");
                Console.WriteLine("*********************************************************");
                Console.WriteLine("*********************************************************\n");

                Console.WriteLine("Would you like to order another Pizza?\nEnter\ntrue: To order again \nfalse:To quit the application");
                quitOption = Convert.ToBoolean(Console.ReadLine());
            } while (quitOption == true);
            Console.WriteLine("\nThank You! Have a great day!!\n");
        }
    }
}
