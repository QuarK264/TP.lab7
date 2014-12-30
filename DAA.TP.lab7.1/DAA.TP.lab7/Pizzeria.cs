namespace DAA.TP.lab7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Pizzeria
    {
        public List<Order> ListofOrders;

        public Pizzeria()
        {
            ListofOrders = new List<Order>();
        }

        public void AddOrder(string name, string address, string phoneNumber)
        {
            ListofOrders.Add(new Order(name, address, phoneNumber));
        }

        public void RemoveOrder(string name, string address, string phoneNumber)
        {
            if (ListofOrders.Contains(ListofOrders.Find(target => target.Name.Contains(name) && target.Address.Contains(address) && target.PhoneNumber.Contains(phoneNumber))))
            {
                ListofOrders.RemoveAll(target => (target.Name.Contains(name) && target.Address.Contains(address) && target.PhoneNumber.Contains(phoneNumber)));
            }
            else
            {
                Console.WriteLine("Нет такого заказа");
            }
        }

        public void ChangeOrderInfo(string name, string address, string phoneNumber, string newName, string newAddress, string newPhoneNumber)
        {
            var order = FindOrder(name, address, phoneNumber);
            ListofOrders.Remove(order);
            order.ChangeOrder(newName, newAddress, newPhoneNumber);
            ListofOrders.Add(order);
        }

        private Order FindOrder(string name, string address, string phoneNumber)
        {
            return ListofOrders.Find(target => target.Name.Contains(name) && target.Address.Contains(address) && target.PhoneNumber.Contains(phoneNumber));
        }

        public void PrintOrdersFromAddress(string address)
        {
            List<Order> FromOneAddress = ListofOrders.FindAll(target => target.Address.Contains(address));
            foreach (Order order in FromOneAddress)
            {
                Console.WriteLine(order.ToString());
            }
        }

        public void PrintPersonsWithMostOrdersInfo()
        {
            List<string> Names = ExtractNames();
            uint MaxOrdersFromPerson = 0;
            uint OrdersFromPerson = 0;
            foreach (string name in Names)
            {
                OrdersFromPerson = (uint)Names.Count<string>(target => target == name);
                if (OrdersFromPerson > MaxOrdersFromPerson)
                {
                    MaxOrdersFromPerson = OrdersFromPerson;
                }
                else
                {
                    OrdersFromPerson = 0;
                }
            }
            PrintPresonsOrders(Names, MaxOrdersFromPerson);
        }

        public void PrintPersonsWithLessOrdersInfo()
        {
            List<string> Names = ExtractNames();
            uint LessOrdersFromPerson = uint.MaxValue;
            uint OrdersFromPerson = 0;
            foreach (string name in Names)
            {
                OrdersFromPerson = (uint)Names.Count<string>(target => target == name);
                if (OrdersFromPerson < LessOrdersFromPerson)
                {
                    LessOrdersFromPerson = OrdersFromPerson;
                }
                else
                {
                    OrdersFromPerson = 0;
                }
            }
            PrintPresonsOrders(Names, LessOrdersFromPerson);
        }

        private void PrintPresonsOrders(List<string> Names, uint OrdersFromPerson)
        {
            string PersonWithNotisableOrders;
            List<string> TempNames = Names;
            for (int i = 0; i < TempNames.Count; i++)
            {
                if (OrdersFromPerson == (uint)Names.Count<string>(target => target == TempNames[i]))
                {
                    PersonWithNotisableOrders = TempNames[i];
                    List<Order> FromPerson = ListofOrders.FindAll(target => target.Name.Contains(PersonWithNotisableOrders));
                    foreach (Order order in FromPerson)
                    {
                        Console.WriteLine(order.ToString());
                    }
                    TempNames.RemoveAll(target => target.Contains(PersonWithNotisableOrders));
                } 
            }
        }

        private List<string> ExtractNames()
        {
            List<string> Names = new List<string>();
            foreach (Order order in ListofOrders)
            {
                Names.Add(order.Name);
            }
            return Names;
        }

        public void OutputOrders(List<Order> ListofOrders, string msg)
        {
            Console.WriteLine(msg);
            foreach (Order order in ListofOrders)
            {
                Console.WriteLine(order.ToString());
            }
        }
    }
}
