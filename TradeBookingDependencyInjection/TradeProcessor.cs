using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeBookingDependencyInjection
{
    public class TradeProcessor : ITradeProcessor
    {
        private readonly ITradeRepository _tradeRepository;
        private readonly ITradeConfirmation _tradeConfirmation;
        private readonly ITradeReporting _tradeReporting;
        
        public TradeProcessor(ITradeRepository tradeRepository, ITradeConfirmation tradeConfirmation, ITradeReporting tradeReporting)
        {
            _tradeRepository = tradeRepository;
            _tradeConfirmation = tradeConfirmation;
            _tradeReporting = tradeReporting;
        }

        public void submitTrade(Swap swap, out string submitreturnmessage)
        {
            string message;
            string returnmessage;

            //Trade Repository
            _tradeRepository.SaveTradeToRepository(swap, out message);
            returnmessage = message + Environment.NewLine + Environment.NewLine;

            //Trade Reporting
            _tradeReporting.SendTradeReportingTicket(swap, out message);
            returnmessage += message + Environment.NewLine + Environment.NewLine;

            //Trade Confirmation
            _tradeConfirmation.SendTradeConfirmationTicket(swap, out message);
            returnmessage += message;

            submitreturnmessage = returnmessage;


        }
    }
}
