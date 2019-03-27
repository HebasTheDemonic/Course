using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class Bank : IBank
    {
        #region Vars and Props

        private readonly string _bankName;
        private readonly string _bankAddress;
        private int _customerCount;
        private List<Account> AccountsInBank = new List<Account>();
        private List<Customer> CustomersInBank = new List<Customer>();
        private Dictionary<int, Customer> DictOfCustomerByID = new Dictionary<int, Customer>();
        private Dictionary<int, Customer> DictOfCustomerByCusNum = new Dictionary<int, Customer>();
        private Dictionary<int, Account> DictOfAccountByAccNum = new Dictionary<int, Account>();
        private Dictionary<Customer, List<Account>> DictOfAccountsOwnedBySameCustomer = new Dictionary<Customer, List<Account>>();
        private float totalManeyInBank = 0f;
        private float profits = 0f;

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
        #endregion

        public Bank(string name, string address)
        {
            this._bankName = name;
            this._bankAddress = address;
        }

        #region Dictionary Getters

        internal Customer GetCustomerByID(int customerID)
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

        internal Customer GetCustomerByNumber(int customerNumber)
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

        internal Account GetAccountByNumber(int accountNumber)
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

        internal List<Account> GetAccountsByCustomer(Customer customer)
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
        #endregion

        #region Functions

        internal void AddNewCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException();
            }
            if (CustomersInBank.Contains(customer))
            {
                throw new CustomerAlreadyExistsException();
            }
            CustomersInBank.Add(customer);
            DictOfCustomerByID.Add(customer.CustomerID, customer);
            DictOfCustomerByCusNum.Add(customer.CustomerNumber, customer);
        }

        internal void OpenNewAccount(Customer customer, Account account)
        {
            if (customer == null)
            {
                throw new ArgumentNullException();
            }
            if (account == null)
            {
                throw new ArgumentNullException();
            }
            if (account.AccountOwner != customer)
            {
                throw new NotSameCustomerException();
            }
            if (AccountsInBank.Contains(account))
            {
                throw new AccountAlreadyExistsException();
            }
            if (!CustomersInBank.Contains(customer))
            {
                AddNewCustomer(customer);
            }
            AccountsInBank.Add(account);
            DictOfAccountByAccNum.Add(account.AccountNumber, account);
            if (DictOfAccountsOwnedBySameCustomer.ContainsKey(customer))
            {
                DictOfAccountsOwnedBySameCustomer[customer].Add(account);
            }
            else
            {
                List<Account> Accounts = new List<Account>();
                Accounts.Add(account);
                DictOfAccountsOwnedBySameCustomer.Add(customer, Accounts);
            }
        }

        internal float Deposit(Account account, int amount)
        {
            totalManeyInBank = +amount;
            account = account + amount;
            return account.Balance;
        }

        internal float Withdraw(Account account, int amount)
        {
            if (account.Balance - amount > account.MaxMinusAllowed)
            {
                totalManeyInBank = -amount;
                account = account - amount;
                return account.Balance;
            }
            else
            {
                throw new BalanceException();
            }
        }

        internal float GetCustomerTotalBalance(Customer customer)
        {
            float customerBalance = 0;
            if (customer == null)
            {
                throw new ArgumentNullException();
            }
            if (!CustomersInBank.Contains(customer))
            {
                throw new CustomerNotFoundException();
            }
            foreach (Account account in DictOfAccountsOwnedBySameCustomer[customer])
            {
                customerBalance = +account.Balance;
            }
            return customerBalance;
        }

        internal void CloseAccount(Account account, Customer customer)
        {
            if (account == null)
            {
                throw new ArgumentNullException();
            }
            if (customer == null)
            {
                throw new ArgumentNullException();
            }
            if (!AccountsInBank.Contains(account))
            {
                throw new AccountNotFoundException();
            }
            AccountsInBank.Remove(account);
            DictOfAccountByAccNum.Remove(account.AccountNumber);
            DictOfAccountsOwnedBySameCustomer[customer].Remove(account);
            this.totalManeyInBank = -account.Balance;
        }

        internal void ChargeAnnualCommision(float percentage)
        {
            float amountDeduced;
            foreach (Customer customer in CustomersInBank)
            {
                foreach (Account account in DictOfAccountsOwnedBySameCustomer[customer])
                {
                    if (account.Balance < 0)
                    {
                        amountDeduced = account.Balance * percentage * 2f;
                        account.Subtract(amountDeduced);
                        profits = +amountDeduced;
                    }
                    else
                    {
                        amountDeduced = account.Balance * percentage;
                        account.Subtract(amountDeduced);
                        profits = +amountDeduced;
                    }
                }
            }
        }

        internal void JoinAccounts(Account account1, Account account2)
        {
            if (account1 == null)
            {
                throw new ArgumentNullException();
            }
            if (account2 == null)
            {
                throw new ArgumentNullException();
            }
            if (account1.AccountOwner != account2.AccountOwner)
            {
                throw new NotSameCustomerException();
            }
            Account account3 = account1 + account2;
            CloseAccount(account1, account1.AccountOwner);
            CloseAccount(account2, account2.AccountOwner);
        }

        #endregion
    }
}
