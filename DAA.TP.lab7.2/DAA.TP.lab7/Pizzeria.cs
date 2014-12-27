namespace DAA.TP.lab7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Pizzeria
    {
        private List<Order> listofOrders;

        public List<Order> ListOfOrders
        {
            get
            {
                return listofOrders;
            }
            set
            {
                listofOrders = value;
            }
        }

        public Order this[int index]
        {
            get
            {
                return listofOrders[index];
            }
            set
            {
                listofOrders[index] = value;
            }
        }

        public Pizzeria()
        {
            listofOrders = new List<Order>();
        }

        public void AddOrder(string name, string address, string phoneNumber)
        {
            listofOrders.Add(new Order(name, address, phoneNumber));
        }

        public void RemoveOrder(string name, string address, string phoneNumber)
        {
            var target = new Order { Name = name, Address = address, PhoneNumber = phoneNumber };
            if (listofOrders.Contains(target))
            {
                listofOrders.Remove(target);
            }
            else
            {
                Console.WriteLine("Нет такого заказа");
            }
        }

        public void ChangeOrderInfo(string name, string newName, string address, string phoneNumber)
        {
            var order = FindOrder(name);
            listofOrders.Remove(order);
            order.ChangeOrder(newName, address, phoneNumber);
            listofOrders.Add(order);
        }

        public Order FindOrder(string name)
        {
            return listofOrders.Find(target => target.Name.Contains(name));
        }

        public void PrintOrdersFromAddress(string address)
        {
            List<Order> FromOneAddress = listofOrders.FindAll(target => target.Address.Contains(address));
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
            foreach (string name in Names)
            {
                if (OrdersFromPerson == (uint)Names.Count<string>(target => target == name))
                {
                    PersonWithNotisableOrders = name;
                    List<Order> FromPerson = listofOrders.FindAll(target => target.Name.Contains(PersonWithNotisableOrders));
                    foreach (Order order in FromPerson)
                    {
                        Console.WriteLine(order.ToString());
                    }
                    break;
                }
            }
        }

        private List<string> ExtractNames()
        {
            List<string> Names = new List<string>();
            foreach (Order order in listofOrders)
            {
                Names.Add(order.Name);
            }
            return Names;
        }
    }
}
