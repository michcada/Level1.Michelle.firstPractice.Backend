using Level1.Michelle.firstPractice.Backend;
using Level1.Michelle.firstPractice.Backend.ProductsFolder;
using System.Numerics;
using System.Runtime.InteropServices;

int orderNum = 0;

//Counts for orders list and order product
int i = 0;
int b = 0;

//Dishes
Dishes spaghetti = new("spaghetti", 10.99);
Dishes lasagna = new("Lasagna", 12.99);
Dishes pizza = new("Pizza", 8);
Dishes calzone = new("Calzone", 6);

//Beverages

Beverages soda = new("Soda", 6.5);
Beverages wine = new("Wine", 9);
Beverages beer = new("Beer", 7.5);

//Orders


//Order list
OrdersList myOrderList = new OrdersList();


while (orderNum < 2)
{
    {
        Console.WriteLine("*--------------------- CREATING NEW ORDER ---------------------*\n");

        Console.WriteLine("Please enter your name");
        string clientName = Console.ReadLine();
        int productCount = 0;
        int ch;
        FinalOrder newOrder = new(clientName, orderNum);
        newOrder.OrderNumber= orderNum+1;
        newOrder.ClientName= clientName;

        //Menu

        Console.WriteLine("|*-------------------- DISHES -------------------*|" + "\n ");
        Console.WriteLine("1. " + spaghetti.Name + "           $" + spaghetti.Price + "\n2. " + lasagna.Name + "             $" + lasagna.Price + "\n3. " + pizza.Name + "               $" + pizza.Price + "\n4. " + calzone.Name + "             $" + calzone.Price);
        Console.WriteLine("\n|*------------------ BEVERAGES ------------------*|" + "\n ");
        Console.WriteLine("5. " + soda.Name + "                $" + soda.Price + "\n6. " + wine.Name + "                $" + wine.Price + "\n7. " + beer.Name + "                $" + beer.Price);
        Console.WriteLine("---------------------------------------------------");
        //Console.WriteLine("\n0.  cancel");
        Console.WriteLine("----------------------------------------------------");

        //Selection logic
        ChooseProducts();
        void ChooseProducts()
        {
            

            if (productCount == 0)
            {
                Console.WriteLine("\nHi, " + clientName + "! Please enter a number to choose Products:\n ");
            }
            else
            {
                Console.WriteLine("Please enter a number choose the product you want to add\n");
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
                        Console.WriteLine("how many spaghetti dishes do you want to add?\n ");
                        int dishes = int.Parse(Console.ReadLine());
                        newOrder.AddObject(spaghetti);
                        newOrder.AddQuantity(dishes);
                        AddProducts();

                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Lasagna added to your order\n ");
                        productCount++;
                        Console.WriteLine("how many lasagna dishes do you want to add?\n ");
                        int dishes = int.Parse(Console.ReadLine());
                        newOrder.AddObject(lasagna);
                        newOrder.AddQuantity(dishes);
                        AddProducts();

                    }
                    break;

                case 3:
                    {
                        Console.WriteLine("Pizza added to your order\n ");
                        productCount++;
                        Console.WriteLine("how many pizza dishes do you want to add?\n ");
                        int dishes = int.Parse(Console.ReadLine());
                        newOrder.AddObject(pizza);
                        newOrder.AddQuantity(dishes);
                        AddProducts();

                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Calzone added to your order\n ");
                        productCount++;
                        Console.WriteLine("how many calzone dishes do you want to add?\n ");
                        int dishes = int.Parse(Console.ReadLine());
                        newOrder.AddObject(calzone);
                        newOrder.AddQuantity(dishes);
                        AddProducts();

                    }
                    break;

                case 5:
                    {
                        Console.WriteLine("Soda added to your order\n ");
                        productCount++;
                        Console.WriteLine("how many soda(s) do you want to add?\n ");
                        int dishes = int.Parse(Console.ReadLine());
                        newOrder.AddObject(soda);
                        newOrder.AddQuantity(dishes);
                        AddProducts();

                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("Wine added to your order\n ");
                        productCount++;
                        Console.WriteLine("how many wine cups do you want to add?\n ");
                        int dishes = int.Parse(Console.ReadLine());
                        newOrder.AddObject(wine);
                        newOrder.AddQuantity(dishes);
                        AddProducts();

                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("Beer added to your order\n ");
                        productCount++;
                        Console.WriteLine("how many beer(s) do you want to add?\n ");
                        int dishes = int.Parse(Console.ReadLine());
                        newOrder.AddObject(beer);
                        newOrder.AddQuantity(dishes);
                        AddProducts();

                    }
                    break;


                default:
                    Console.WriteLine("Your number has to correspond to something in the menu!");
                    AddProducts();
                    break;
            }
        }

        void AddProducts()
        {
            Console.WriteLine("\n Do you want to add something else?");
            Console.WriteLine("type 1 for Yes\ntype 2 for No");
            int selection = int.Parse(Console.ReadLine());
            if (selection == 1)
            {
                ChooseProducts();
            }
            else
            {
                myOrderList.AddOrder(newOrder);
                Console.WriteLine("You ordered:");

                foreach (var product in myOrderList.Orders[i].OrderList)
                {
                    Console.WriteLine(myOrderList.Orders[i].OrderList[b].quantity + " " + myOrderList.Orders[i].OrderList[b].Name + "(s)");
                    b++;
                }
                b = 0;
                i++;

                newOrder.CalculateTotal();
                Console.WriteLine("You're going to pay: $" + Math.Round(newOrder.total, 2) + "\n");
                Console.WriteLine("Please select your payment method");
                Console.WriteLine("type 1 for Cash\ntype 2 for Card");
                int paySel = int.Parse(Console.ReadLine());
                string paymentM;
                if (paySel == 1)
                {
                    paymentM = "Cash";
                    Console.WriteLine("You selected " + paymentM + "\n");
                }
                else
                {
                    paymentM = "Card";
                    Console.WriteLine("You selected " + paymentM + "\n");
                }

                // Reset dishes quantity

                spaghetti.quantity = 0;
                lasagna.quantity = 0;
                pizza.quantity = 0;
                calzone.quantity = 0;

                // Reset beverages quantity

                soda.quantity= 0;
                wine.quantity = 0;
                beer.quantity = 0;
            }
        }
        orderNum++;
    }
}

Console.WriteLine("********************** PREPARING ORDERS *********************");
i = 0;
b = 0;

foreach (var order in myOrderList.Orders)
{
    Console.WriteLine("Delivering Order {0}, Customer: {1}", myOrderList.Orders[i].OrderNumber, myOrderList.Orders[i].ClientName);
    foreach (var product in myOrderList.Orders[i].OrderList)
    {
        Console.WriteLine(myOrderList.Orders[i].OrderList[b].quantity +" "+ myOrderList.Orders[i].OrderList[b].Name + "(s)");
        Console.WriteLine("cost: $" + Math.Round(myOrderList.Orders[i].total, 2));
        Console.Write("Payment method: " + myOrderList.Orders[i].PaymentMethod + "\n");
        b++;
    }
    i++;
    b = 0;
}