using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeBookingDependencyInjection
{
    public class TradeReporting : ITradeReporting
    {
        public TradeReporting()
        {
        }

        public void SendTradeReportingTicket(Swap swap, out string message)
        {
            //Connects with Trade Reporting API to send regulatory reporting ticket
            message = swap.swapidentifier + @" - trade reporting ticket sent.";
        }
    }
}
