using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeBookingDependencyInjection
{
    public class SwapIdentifier
    { 
        public SwapIdentifier()
        {
        }

        public int swapidentifer()
        {
            Random rnd = new Random();
            return rnd.Next();
        }
    }
}
