using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class InterestAccount : Account
    {


        protected float interestRate;

        public InterestAccount(float money, float interestRate) : base(money)
        {
            this.interestRate = interestRate;
        }

        

        public virtual void addInterest()
        {
            money = money * interestRate;
        }

    }
}
