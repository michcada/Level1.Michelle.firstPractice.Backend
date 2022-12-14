using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level1.Michelle.firstPractice.Backend
{
    internal class OrdersList
    {
        public List<FinalOrder> Orders = new List<FinalOrder>();

        public OrdersList ()
        {

        }
        public void AddOrder(FinalOrder product)
        {
            Orders.Add(product);
        }
    }
}
