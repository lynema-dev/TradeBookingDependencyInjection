namespace TradeBookingDependencyInjection
{
    public interface ITradeProcessor
    {
        void submitTrade(Swap swap, out string submitreturnmessage);
    }
}