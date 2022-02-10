using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulationExercise
{
    public class BankAccount
    {
        private double _balance = 0;

        public void Deposit (double depAmount)
        {
            Console.WriteLine($"Deposting {depAmount, 0:C} into your account...");

            _balance = _balance += depAmount;
        }

        public double GetBalance ()
        {

            return _balance;
        }

       
        
        

        

    }
}
