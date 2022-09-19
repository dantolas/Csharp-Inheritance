using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Card
    {
        private Account account;
        private int id;
        private int limit;

        public Card(int id, int limit, Account account)
        {
            this.id = id;
            this.limit = limit;
            this.account = account;
        }

        public void payWithCard(float amount)
        {
            if(amount > limit)
            {
                throw new ArgumentException("The amount is above the card's limit.");
            }
            account.takeMoney(amount);
        }


    }
}
