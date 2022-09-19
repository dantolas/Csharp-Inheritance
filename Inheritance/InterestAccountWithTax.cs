using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class InterestAccountWithTax : InterestAccount
    {


        private float tax;

        public InterestAccountWithTax(float money, float interestRate, float tax) : base(money, interestRate)
        {
            this.tax = tax;
        }

       

        public override void addInterest()
        {
            money *= interestRate;
            money -= tax;
        }
    }
}
