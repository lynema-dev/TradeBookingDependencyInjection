namespace TradeBookingDependencyInjection
{
    public interface ITradeReporting
    {
        void SendTradeReportingTicket(Swap swap, out string message);
    }
}