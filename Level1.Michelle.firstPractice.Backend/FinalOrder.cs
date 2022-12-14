using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Level1.Michelle.firstPractice.Backend;
using Level1.Michelle.firstPractice.Backend.ProductsFolder;

namespace Level1.Michelle.firstPractice.Backend
{
    internal class FinalOrder
    {
        public string ClientName { get; set; }
        public int OrderNumber { get; set; }
        public string PaymentMethod { get; set; }
        public List<Products> OrderList = new();
        public List<int> Quantities = new();
        public double total;

        public FinalOrder(string cName, int orderNumber ) 
        { 
        this.ClientName = cName;
        this.OrderNumber = orderNumber;
        this.PaymentMethod = "define";
        }
     
        public double CalculateTotal()
        {
            foreach (Products product in OrderList)
            {
                var price = product.Price;
                var quantity = product.quantity;
                total += price * quantity;
            }
            return total;
        }

        public void AddObject(Products product)
        {
            OrderList.Add(product);
        }
        public void AddQuantity(int quant)
        {
            Quantities.Add(quant);
        }
        public string DefinePM(string paymentMethodR)
        {
            this.PaymentMethod = paymentMethodR;
            return PaymentMethod;
        }

    }
}