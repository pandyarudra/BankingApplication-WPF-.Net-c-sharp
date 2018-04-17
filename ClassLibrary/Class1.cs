using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Person
    {
        private string Password;
        public readonly string SIN;
        public bool IsAuthenticated { get; private set; }
        public string Name { get; private set; }
        public Person(string name, string sin)
        {
            Name = name;
            SIN = sin;
            Password = sin.Substring(0, 3);
        }
        public void Login(string password)
        {
            if (password != Password)
                throw new AccountException("Password doesn't match");
            if (password == Password)
                IsAuthenticated = true;
        }
        public void Logout()
        {
            IsAuthenticated = false;
        }
        public override string ToString()
        {
            return string.Format("{0} ({1})", Name, (IsAuthenticated ? "authenticated" : "not authenticated"));
        }
    }
    public struct Transaction
    {
        public readonly string AccountNumber;
        public readonly double Amount;
        public readonly double EndBalance;
        public readonly Person Originator;
        public readonly DateTime Time;
        public Transaction(string accountNumber, double amount, double endBalance, Person person, DateTime time)
        {
            AccountNumber = accountNumber;
            Amount = amount;
            EndBalance = endBalance;
            Originator = person;
            Time = time;
        }
        public override string ToString()
        {
            return string.Format("{0,-10} {1,-10} {2,-10} {3,-10:c2} at {4,5}\n", AccountNumber, Originator.Name, (Amount < 0) ? "Withdraw" : "Deposit", Math.Abs(Amount), Time.ToShortTimeString());
        }
    }
    public class AccountException : Exception
    {
        public const string ACCOUNT_DOES_NOT_EXIST = "This account doesn't exist!";
        public const string CREDIT_LIMIT_HAS_BEEN_EXCEEDED = "Credit limit has been exceeded!";
        public const string NAME_NOT_ASSOCIATED_WITH_ACCOUNT = "Name is not associated with account!";
        public const string NO_OVERDRAFT = "No overdraft!";
        public const string PASSWORD_INCORRECT = "Password is not correct!";
        public const string USER_DOES_NOT_EXIST = "User doesn't exist!";
        public const string USER_NOT_LOGGED_IN = "User has not logged-in!";
        public AccountException() : base()
        { }
        public AccountException(string type) : base(type)
        { }
    }
    public abstract class Account
    {
        public readonly List<Person> holders = new List<Person>();
        public readonly List<Transaction> transactions = new List<Transaction>();
        public readonly string Number;
        private static int LAST_NUMBER = 100000;
        public double Balance { get; protected set; }
        public double LowestBalance { get; protected set; }
        public Account(string type, double balance)
        {
            Balance = balance;
            LowestBalance = balance;
            Number = type + "-" + LAST_NUMBER;
            LAST_NUMBER++;
        }
        public void AddUser(Person person)
        {
            holders.Add(person);
        }
        public virtual void Deposit(double amount, Person person)
        {
            Balance += amount;
            if (LowestBalance > Balance)
                LowestBalance = Balance;
            Transaction t = new Transaction(Number, amount, Balance, person, DateTime.Now);
            transactions.Add(t);
        }
        public bool IsHolder(string name)
        {
            bool result = false;
            foreach (Person p in holders)
            {
                if (p.Name == name)
                    result = true;
            }
            return result;
        }
        public abstract void PrepareMonthlyReport();
        public override string ToString()
        {
            string s = "";
            string g = "";
            foreach (Person p in holders)
            {
                s += (p.Name+"%");
            }
            foreach (Transaction t in transactions)
            {
                g += (t.ToString()+"%");
            }
            return string.Format("Account Number:{0}%Account Holders:%{1}Account Balance:{2:c2}%Account Transactions:%{3}", Number, s, Balance, g);
        }
    }
    public class CheckingAccount : Account
    {
        private const double COST_PER_TRANSACTION = 0.05;
        private const double INTEREST_RATE = 0.005;
        private bool hasOverdraft;
        public CheckingAccount(double balance = 0, bool hasOverdraft = false) : base("CK", balance)
        {
            this.hasOverdraft = hasOverdraft;
        }
        public new void Deposit(double amount, Person person)
        {
            if (IsHolder(person.Name))
            {
                base.Deposit(amount, person);
            }
        }
        
        public void Withdraw(double amount, Person person)
        {
            if (!IsHolder(person.Name))
            {
                throw new AccountException(AccountException.NAME_NOT_ASSOCIATED_WITH_ACCOUNT);
            }
            if (!person.IsAuthenticated)
            {
                throw new AccountException(AccountException.USER_NOT_LOGGED_IN);
            }
            if ((amount > Balance) && !hasOverdraft)
            {
                throw new AccountException(AccountException.NO_OVERDRAFT);
            }
            else
                base.Deposit(-amount, person);
        }
        public override void PrepareMonthlyReport()
        {
            double serviceCharge = COST_PER_TRANSACTION * transactions.Count;
            double interest = Balance * INTEREST_RATE / 12;
            Balance += interest;
            Balance -= serviceCharge;
            transactions.Clear();
        }
    }
    public class SavingAccount : Account
    {
        private const double COST_PER_TRANSACTION = 0.05;
        private const double INTEREST_RATE = 0.015;
        public SavingAccount(double balance = 0) : base("SV", balance)
        { }
        public new void Deposit(double amount, Person person)
        {
            if (IsHolder(person.Name))
                base.Deposit(amount, person);
        }
        public void Withdraw(double amount, Person person)
        {
            if (!IsHolder(person.Name))
            {
                throw new AccountException(AccountException.USER_NOT_LOGGED_IN);
            }
            if (!person.IsAuthenticated)
            {
                throw new AccountException(AccountException.USER_NOT_LOGGED_IN);
            }
            if (amount > Balance)
            {
                throw new AccountException(AccountException.NO_OVERDRAFT);
            }
            if (person.IsAuthenticated)
            {
                if (amount < Balance)
                    base.Deposit(-amount, person);
            }
        }
        public override void PrepareMonthlyReport()
        {
            double serviceCharge = COST_PER_TRANSACTION * transactions.Count;
            double interest = Balance * INTEREST_RATE / 12;
            Balance += interest;
            Balance -= serviceCharge;
            transactions.Clear();
        }
    }
    public class VisaAccount : Account
    {
        private double creditLimit;
        private const double INTEREST_RATE = 0.1995;
        public VisaAccount(double balance = 0, double creditLimit = 1200) : base("VS", balance)
        {
            this.creditLimit = creditLimit;
        }
        public void DoPayment(double amount, Person person)
        {
            Deposit(amount, person);
        }
        public void DoPurchase(double amount, Person person)
        {
            if (!IsHolder(person.Name))
            {
                throw new AccountException(AccountException.NAME_NOT_ASSOCIATED_WITH_ACCOUNT);
            }
            if (!person.IsAuthenticated)
            {
                throw new AccountException(AccountException.USER_NOT_LOGGED_IN);
            }
            if (amount > Balance)
            {
                throw new AccountException(AccountException.CREDIT_LIMIT_HAS_BEEN_EXCEEDED);
            }
            if (person.IsAuthenticated)
            {
                if (amount < Balance)
                    Deposit(-amount, person);
            }
        }
        public override void PrepareMonthlyReport()
        {
            double interest = LowestBalance * INTEREST_RATE / 12;
            Balance -= interest;
            transactions.Clear();
        }
    }
    public static class Bank
    {
        private static List<Account> accounts;
        private static List<Person> persons;
        public static void addAccount(Account a)
        {
            accounts.Add(a);
        }
        static Bank()
        {
            CreatePersons();
            CreateAccounts();
        }
        public static void addUser(Person p)
        {
            persons.Add(p);
        }
        private static void CreatePersons()
        {
            persons = new List<Person>()
            {
                new Person("Narendra", "1234-5678"),
                new Person("Ilia", "2345-6789"),
                new Person("Tom", "3456-7890"),
                new Person("Syed", "4567-8901"),
                new Person("Arben", "5678-9012"),
                new Person("Patrick", "6789-0123"),
                new Person("Yin", "7890-1234"),
                new Person("Hao", "8901-2345"),
                new Person("Jake", "9012-3456")
            };
        }
        private static void CreateAccounts()
        {
            accounts = new List<Account>{
                new VisaAccount(), //VS-100000
                new VisaAccount(550, -500), //VS-100001
                new SavingAccount(5000), //SV-100002
                new SavingAccount(), //SV-100003
                new CheckingAccount(2000), //CK-100004
                new CheckingAccount(1500, true) };//CK-100005

            accounts[0].AddUser(persons[0]);
            accounts[0].AddUser(persons[1]);
            accounts[0].AddUser(persons[2]);
            accounts[1].AddUser(persons[3]);
            accounts[1].AddUser(persons[4]);
            accounts[1].AddUser(persons[2]);
            accounts[2].AddUser(persons[0]);
            accounts[2].AddUser(persons[5]);
            accounts[2].AddUser(persons[6]);
            accounts[3].AddUser(persons[5]);
            accounts[3].AddUser(persons[6]);
            accounts[4].AddUser(persons[5]);
            accounts[4].AddUser(persons[7]);
            accounts[4].AddUser(persons[8]);
            accounts[5].AddUser(persons[5]);
            accounts[5].AddUser(persons[6]);
        }

        public static void PrintAccounts()
        {
            foreach (Account a in accounts)
            {
                Console.WriteLine(a);
            }
        }
        public static List<string> returnAccounts(Person p)
        {
            List<string> results=new List<string>();
            foreach (Account a in accounts)
            {
                if (p != null)
                {
                    if (a.IsHolder(p.Name))
                        results.Add(a.Number);
                }                
            }
            return results;
        }
        public static void PrintPersons()
        {
            foreach (Person p in persons)
            {
                Console.WriteLine(p);
            }
        }
        public static Person GetPerson(string name)
        {
            Person result = null;
            bool flag = true;
            foreach (Person p in persons)
            {
                if (p.Name == name)
                {
                    flag = false;
                    result = p;
                }
            }
            if (flag)
                throw new AccountException(AccountException.USER_DOES_NOT_EXIST);
            return result;
        }
        public static Account GetAccount(string number)
        {
            Account result = null;
            bool flag = true;
            foreach (Account a in accounts)
            {
                if (a.Number == number)
                {
                    flag = false;
                    result = a;
                }
            }
            if (flag)
                throw new AccountException(AccountException.ACCOUNT_DOES_NOT_EXIST);
            return result;
        }
    }
}

