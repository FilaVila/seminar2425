using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class Bank_account
    {
        public int accountNumber;
        public string holderName;
        public string currency;
        public double balance;

        public Bank_account(string holderName, string currency)
        {
            Random rnd = new Random();
            this.accountNumber = rnd.Next(100000000, 1000000000);
            this.holderName = holderName;
            this.currency = currency;
            this.balance = 0;
        }
        
        public void Deposit(double amount) 
        {
            balance = balance + amount;
        }
        public void Withdraw(double amount) 
        {
            if (amount>balance)
            {
                Console.WriteLine("Sry brácho si brouk jak Řehoř Samsa");
            }
            balance = balance - amount;
        }
        public void Transfer(int accountNumber2, int amount, Bank_account account1, Bank_account account2) 
        {
            account2.accountNumber = accountNumber2;
            if (amount<account1.balance) 
            {
                Console.WriteLine("Omlouvám se, ale na vašem účtu není dostatek prostředků");
            }
            account1.Withdraw(amount);
            account2.Deposit(amount);
            Console.WriteLine("převod byl úspěšný");
        }
        public void WriteData() 
        {
            Console.WriteLine("Na vašem účtu číslo:"+accountNumber +", na jméno: "+ holderName + " v měně "+currency +"je aktuálně: "+balance+" "+currency);
        }
    }
}
