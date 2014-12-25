namespace DAA.TP.lab7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Pizzeria
    {
        public List<Order> ListofOrders { get; set; }

        public void AddOrder(string name, string address, string phoneNumber)
        {
            ListofOrders.Add(new Order(name, address, phoneNumber));
        }

        public void RemoveOrder(string name)
        {
            var target = new Order { Name = name};
            if (ListofOrders.Contains(target))
            {
                ListofOrders.Remove(target);
            }
            else
            {
                Console.WriteLine("Нет такого заказа");
            }
        }

        public void ChangeOrderInfo(string name, string newName, string address, string phoneNumber)
        {
            var order = FindOrder(name);
            order.ChangeOrder(name, newName, phoneNumber);
        }

        public Order FindOrder(string name)
        {
            return ListofOrders.Find(target => target.Name.Contains(name));
        }
    }
}
