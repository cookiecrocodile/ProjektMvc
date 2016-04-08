using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projektmvc.Models
{
    public class OrderItem
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public int Price { get; private set; }

        public int Numbers { get; private set; }

        public OrderItem(int id, string name, int price, int number)
        {
            Id = id;
            Name = name;
            Price = price;
            Numbers = number;
        }

        //Sätter om propertyn number på ett inskickat OrderItem till det antal man anger
        public static void EditNumberOfItems(OrderItem item, int num)
        {
            item.Numbers = num;
        }

        public static int CalculateNumberOfItems(List<OrderItem> order)
        {
            int itemTotal = 0;

            foreach (OrderItem item in order)
            {
                itemTotal += item.Numbers;
            }

            return itemTotal;
        }

        public static int CalculateTotal(List<OrderItem> order)
        {
            int total = 0;

            foreach (OrderItem item in order)
            {
                total += (item.Numbers * item.Price);
            }

            return total;
        }
    }
}