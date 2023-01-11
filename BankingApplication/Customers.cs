using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    internal class Customers
    {
        private string firstName;
        private string lastName;
        private string email;
        private int phoneNumber;
        private int moneyAmount = 0;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                phoneNumber = value;
            }
        }

        public int MoneyAmount
        {
            get { return moneyAmount; }
            set
            {
                moneyAmount = value;
            }
        }

        public Customers(string first, string last, string email, int phoneNumber, int moneyAmount)
        {
            FirstName = first;
            LastName = last;
            Email = email;
            PhoneNumber = phoneNumber;
            MoneyAmount = moneyAmount;
        }

        public int AddMoney(int amount)
        {
            return moneyAmount += amount;
        }

        public int RemoveMoney(int amount)
        {
            return moneyAmount -= amount;

            // need to add if for checking positive amount
        }
    }
}
