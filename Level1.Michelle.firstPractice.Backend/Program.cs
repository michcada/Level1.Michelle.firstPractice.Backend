using Level1.Michelle.firstPractice.Backend.Products;
using System.Numerics;
using System.Runtime.InteropServices;

for (int i = 0; i < 5; i++)
{
    {
        Console.WriteLine("Please enter your name");
        string clientName = Console.ReadLine();
        int productCount = 0;
        int ch;

        //Dishes
        Dishes spaghetti = new("spaghetti", 10.99);
        Dishes lasagna = new("Lasagna", 12.99);
        Dishes pizza = new("Pizza", 8);
        Dishes calzone = new("Calzone", 6);

        //Beverages

        Beverages soda = new("Soda", 6.5);
        Beverages wine = new("Wine", 9);
        Beverages beer = new("Beer", 7.5);

        //Menu

        Console.WriteLine("|*-------------------- DISHES -------------------*|" + "\n ");
        Console.WriteLine("1. " + spaghetti.Name + "           $" + spaghetti.Price + "\n2. " + lasagna.Name + "             $" + lasagna.Price + "\n3. " + pizza.Name + "               $" + pizza.Price + "\n4. " + calzone.Name + "             $" + calzone.Price);
        Console.WriteLine("\n|*------------------ BEVERAGES ------------------*|" + "\n ");
        Console.WriteLine("5. " + soda.Name + "                $" + soda.Price + "\n6. " + wine.Name + "                $" + wine.Price + "\n7. " + beer.Name + "                $" + beer.Price);
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("\n0.  Send Order");
        Console.WriteLine("----------------------------------------------------");

        //Selection logic
        ChooseProducts();
        void ChooseProducts()
        {
            if (productCount == 0)
            {
                Console.WriteLine("\nHi, " + clientName + "! Please enter a number to choose Products:" + "\n ");
            }
            else
            {
                Console.WriteLine("Please enter a number choose the product you want to add ");
            };
            ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 0:
                    if (productCount == 0)
                    {
                        Console.WriteLine("You haven't ordered anything");
                    }
                    break;

                case 1:
                    {
                        Console.WriteLine("Spaghetti added to your order\n ");
                        productCount++;
                        Console.WriteLine("how many Spaghetti dishes do you want to add?\n ");
                        int dishes = int.Parse(Console.ReadLine());
                        spaghetti.quantity += dishes;
                        AddProducts();
                    }
                    break;

                default:
                    Console.WriteLine("Your number has to correspond to something in the menu!");
                    break;
            }
        }

        void AddProducts()
        {
            Console.WriteLine("Do you want to add something else?");
            Console.WriteLine("waos type 1 for Yes\ntype 2 for No");
            int selection = int.Parse(Console.ReadLine());
            if (selection == 1)
            {
                ChooseProducts();
            }
            else
            {
                Console.WriteLine("You ordered");

            }
        }
    }
}