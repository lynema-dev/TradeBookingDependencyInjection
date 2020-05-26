using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeBookingDependencyInjection
{
    public class TradeConfirmation : ITradeConfirmation
    {
        public TradeConfirmation()
        {
        }

        public void SendTradeConfirmationTicket(Swap swap, out string message)
        {
            //Connects with confirmation API to send trade details for matching process
            message = swap.swapidentifier + @" - trade ticket sent for confirmation matching process.";
        }
    }
}
