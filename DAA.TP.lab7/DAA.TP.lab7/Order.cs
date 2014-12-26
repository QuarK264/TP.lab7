namespace DAA.TP.lab7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public struct Order
    {
        public string Name;
        public string Address;
        public string PhoneNumber;

        public Order(string name, string address, string phoneNumber)
        {
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return "Имя заказчика: " + Name + ", адресс: " + Address + ", номер телефона: " + PhoneNumber + ".";
        }

        public void ChangeOrder(string name, string address, string phoneNumber)
        {
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }
    }
}
