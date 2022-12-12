double total;
int y = 0;
int i = 0;
string x = string.Empty;
List<string> dishesList = new List<string>();
List<string> orderlist = new List<string>();

IDictionary<string, double> dishes = new Dictionary<string, double>();

IDictionary<string, double> beverages = new Dictionary<string, double>();

//Add dishes and prices

dishes.Add("Spaghetti", 10.99);
dishes.Add("Lasagna", 12.99);
dishes.Add("Pizza", 8);
dishes.Add("calzone", 6);

beverages.Add("Soda", 6.5);
beverages.Add("Wine",9);
beverages.Add("Beer", 7.5);

foreach (var item in dishes)
{
    dishesList.Add(item.Key);
}

void showMenu()
{
    
    Console.WriteLine("1. " + dishesList[0]);
    Console.WriteLine("2. " + dishesList[1]);
    Console.WriteLine("3. " + dishesList[2]);
    Console.WriteLine("4. " + dishesList[3]);
    Console.WriteLine("0.  Exit");
    x = Console.ReadLine();
    y += Convert.ToInt32(x);
    i++;

    if (x != "0" && i<5)
    {
        showMenu();
        y += Convert.ToInt32(x);
    }
}

if (x != "0")
{
    showMenu();
    y += Convert.ToInt32(x);
}
