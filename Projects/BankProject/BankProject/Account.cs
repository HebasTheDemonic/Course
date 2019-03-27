using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class Account
    {
        static private int numberOfAcc = 1;
        private readonly int _accountNumber;
        private readonly Customer _accountOwner;
        private int _maxMinusAllowed;

        public int AccountNumber
        {
            get
            {
                return _accountNumber;
            }
        }

        public int Balance { get; private set; }

        public Customer AccountOwner
        {
            get
            {
                return _accountOwner;
            }
        }

        public int MaxMinusAllowed
        {
            get
            {
                return _maxMinusAllowed;
            }
        }

        public Account(Customer customer, int monthlyIncome)
        {
            _maxMinusAllowed = -3 * monthlyIncome;
            _accountNumber = numberOfAcc;
            numberOfAcc++;
            _accountOwner = customer;
            Balance = 0;
        }

        public void Add (int amount)
        {
            if (amount >= 0)
            {
                this.Balance = this.Balance + amount;
            }
            else
            {
                throw new CannotUseNegativeAmountException("Amount to add must be higher then 0.");
            }
        }

        public void Subtract (int amount)
        {
            if (amount >= 0)
            {
                this.Balance = this.Balance - amount;
            }
            else
            {
                throw new CannotUseNegativeAmountException("Amount to subtract must be higher then 0.");
            }
        }

        public override bool Equals(object obj)
        {
            Account account = obj as Account;
            return (this.AccountNumber==account.AccountNumber);
        }

        public override int GetHashCode()
        {
            return this.AccountNumber;
        }

        public static bool operator == (Account ac1, Account acc2)
        {
            if (ac1.AccountNumber == acc2.AccountNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator != (Account ac1, Account ac2) => !(ac1 == ac2);

        public static Account operator + (Account ac1, Account ac2)
        {
            int monthlyIncome = ac1._maxMinusAllowed / 3;
            if (ac1.MaxMinusAllowed > ac2.MaxMinusAllowed)
            {
                monthlyIncome = ac2._maxMinusAllowed / 3;
            }
            Account ac3 = new Account(ac1.AccountOwner, monthlyIncome);
            ac3.Balance = ac1.Balance + ac2.Balance;
            return ac3;
        }

        public static Account operator + (Account ac1, int amount)
        {
            if (amount >= 0)
            {
                ac1.Balance = ac1.Balance + amount;
            }
            else
            {
                throw new CannotUseNegativeAmountException("Amount to add must be higher then 0.");
            }
            return ac1;
        }

        public static Account operator -(Account ac1, int amount)
        {
            if (amount >= 0)
            {
                ac1.Balance = ac1.Balance - amount;
            }
            else
            {
                throw new CannotUseNegativeAmountException("Amount to subtract must be higher then 0.");
            }
            return ac1;
        }
    }
}
