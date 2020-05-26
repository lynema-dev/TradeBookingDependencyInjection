using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeBookingDependencyInjection
{
    public class TradeRepository : ITradeRepository
    {
        public TradeRepository()
        {
        }

        public void SaveTradeToRepository(Swap swap, out string message)
        {
            //Connects with internal database to save trade details
            message = swap.swapidentifier + @" - trade saved to repository.";
        }
    }
}
