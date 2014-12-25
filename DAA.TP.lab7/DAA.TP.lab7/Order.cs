namespace DAA.TP.lab7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public struct Order
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public override string DispalyInfo()
        {
            return "Имя заказчика: " + Name + ", адресс: " + Address + ", номер телефона: " + PhoneNumber + ".";
        }
    }
}
