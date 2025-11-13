namespace BankApp
{
    public class Customer
    {
        private int _customerNumber;
        private string _name;
        private string _contact;
        private bool _isStaff;

        public Customer(int customerNumber, string name, string contact, bool isStaff = false)
        {
            _customerNumber = customerNumber;
            _name = name;
            _contact = contact;
            _isStaff = isStaff;
        }

        public int GetCustomerNumber() => _customerNumber;
        public string GetName() => _name;
        public string GetContact() => _contact;
        public void SetContact(string v) => _contact = v;
        public bool IsStaff() => _isStaff;
    }
}
