using HomeWork04_Transport.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork04_Transport
{
    class Implement : IEqualityComparer<TicketPrice>
    {
        public bool Equals(TicketPrice x, TicketPrice y)
        {
            return x.Startstation == y.Startstation;
        }

        public int GetHashCode(TicketPrice obj)
        {
            return obj.Startstation.GetHashCode();
        }
    }
}
