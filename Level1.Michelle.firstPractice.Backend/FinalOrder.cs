using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Level1.Michelle.firstPractice;

namespace Level1.Michelle.firstPractice.Backend
{
    internal class FinalOrder
    {
        public string ClientName { get; set; }
        public int OrderNumber { get; set; }



        public FinalOrder(string cName, int orderNumber ) 
        { 
        this.ClientName = cName;
        this.OrderNumber = orderNumber;
        List<object> OrderList = new();
        }
     
        public void CalculateTotal()
        {

        }

    }
}
//