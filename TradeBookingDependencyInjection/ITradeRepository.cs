namespace TradeBookingDependencyInjection
{
    public interface ITradeRepository
    {
        void SaveTradeToRepository(Swap swap, out string message);
    }
}