using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class Bank : IBank
    {
        private readonly string _bankName;
        private readonly string _bankAddress;
        private int _customerCount;
        private List<Account> AccountsInBank = new List<Account>();
        private List<Customer> CustomersInBank = new List<Customer>();
        private Dictionary<int, Customer> DictOfCustomerByID = new Dictionary<int, Customer>();
        private Dictionary<int, Customer> DictOfCustomerByCusNum = new Dictionary<int, Customer>();
        private Dictionary<int, Account> DictOfAccountByAccNum = new Dictionary<int, Account>();
        private Dictionary<Customer, List<Account>> DictOfAccountsOwnedBySameCustomer = new Dictionary<Customer, List<Account>>();
        private int totalManeyInBank = 0;
        private int profits = 0;

        public string Name
        {
            get
            {
                return _bankName;
            }
        }

        public string Address
        {
            get
            {
                return _bankAddress;
            }
        }

        public int CustomerCount
        {
            get
            {
                return _customerCount;
            }
        }

        public Bank(string name, string address)
        {
            this._bankName = name;
            this._bankAddress = address;
        }

        internal Customer GetCustomerByID (int customerID)
        {
            if (DictOfCustomerByID.TryGetValue(customerID, out Customer customer))
            {
                return customer;
            }
            else
            {
                throw new CustomerNotFoundException();
            }
        }

        internal Customer GetCustomerByNumber (int customerNumber)
        {
            if (DictOfCustomerByCusNum.TryGetValue(customerNumber, out Customer customer))
            {
                return customer;
            }
            else
            {
                throw new CustomerNotFoundException();
            }
        }

        internal Account GetAccountByNumber (int accountNumber)
        {
            if (DictOfAccountByAccNum.TryGetValue(accountNumber, out Account account))
            {
                return account;
            }
            else
            {
                throw new AccountNotFoundException();
            }
        }

        internal List<Account> GetAccountsByCustomer (Customer customer)
        {
            if (DictOfAccountsOwnedBySameCustomer.TryGetValue(customer, out List<Account> accountList))
            {
                return accountList;
            }
            else
            {
                throw new AccountNotFoundException();
            }
        }
    }
}
