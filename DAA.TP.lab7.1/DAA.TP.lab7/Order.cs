namespace DAA.TP.lab7
{
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
