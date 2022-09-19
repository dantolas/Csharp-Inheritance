using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Human
    {
        protected int age;

        public int getAge()
        {
            return age;
        }

        public virtual bool lie()
        {
            Random rng = new Random();
            int random = rng.Next(0,11);

            return random > 5;
        }

    }
}
