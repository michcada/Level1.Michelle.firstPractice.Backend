using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Level1.Michelle.firstPractice.Backend;
using Level1.Michelle.firstPractice.Backend.Products;

namespace Level1.Michelle.firstPractice.Backend
{
    internal class FinalOrder
    {
        public string ClientName { get; set; }
        public int OrderNumber { get; set; }
        List<object> OrderList = new();
        public double total;

        public FinalOrder(string cName, int orderNumber ) 
        { 
        this.ClientName = cName;
        this.OrderNumber = orderNumber;

        }
     
        public double CalculateTotal()
        {
            foreach (Dishes product in OrderList)
            {
                var price = product.Price;
                var quantity = product.quantity;
                total += price * quantity;
            }
            return total;
        }

        public void AddObject(Dishes dish)
        {
            OrderList.Add(dish);
        }

        public void AddObject(Beverages beve)
        {
            OrderList.Add(beve);
        }

    }
}