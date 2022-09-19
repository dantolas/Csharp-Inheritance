using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Politician : Human
    {
        public override bool lie()
        {
            return false;
        }
    }
}
