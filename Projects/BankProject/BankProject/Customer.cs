using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class Customer
    {
        private static int numberOfCust=1;
        private readonly int _customerID;
        private readonly int _customerNumber;
        public string Name { get; private set; }
        public int PhNumber { get; private set; }

        public int CustomerID
        {
            get
            {
                return _customerID;
            }
               
        }

        public int CustomerNumber
        {
            get
            {
                return _customerNumber;
            }
        }

        public Customer(int id, string name, int phone)
        {
            this._customerNumber = numberOfCust;
            numberOfCust++;
            this._customerID = id;
            this.PhNumber = phone;
            this.Name = name;
        }
        
        public static bool operator == (Customer cust1, Customer cust2)
        {
            if (cust1.CustomerNumber == cust2.CustomerNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Customer cust1, Customer cust2) => !(cust1 == cust2);

        public override bool Equals(object obj)
        {
            Customer c = obj as Customer;
            return this == c;
        }

        public override int GetHashCode()
        {
            return this.CustomerNumber;
        }
    }
}
