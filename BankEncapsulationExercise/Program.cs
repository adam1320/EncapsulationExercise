using System;

namespace BankEncapsulationExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount MyAccount = new BankAccount();

            Console.WriteLine("How much would you like to deposit into your account today?");
            double depositAmount = (double.Parse(Console.ReadLine()));
            
            MyAccount.Deposit(depositAmount);
            double currentBalance = MyAccount.GetBalance();
            
            Console.WriteLine($"Your balance is {currentBalance, 0:C}");
        }
    }
}
