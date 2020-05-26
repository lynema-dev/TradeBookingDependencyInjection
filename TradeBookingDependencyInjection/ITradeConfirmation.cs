namespace TradeBookingDependencyInjection
{
    public interface ITradeConfirmation
    {
        void SendTradeConfirmationTicket(Swap swap, out string message);
    }
}