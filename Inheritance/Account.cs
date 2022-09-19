using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Account
    {

        protected float money;

       
       

        public Account(float money)
        {
            if(money < 0)
            {
                throw new ArgumentException("An account cannot be created with negative balance.");
            }
            this.money = money;
        }

        


        public virtual float getMoney()
        {
            return money;
        }


        public virtual void addMoney(float amount)
        {
            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            money += amount;
        }
        
        public virtual float takeMoney(float amount)
        {
            if(money < amount)
            {
                throw new Exception("Not enough balance on the account");
            }

            money -= amount;
            return amount;
        }
    }
}
