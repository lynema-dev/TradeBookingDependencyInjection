using System;
using Xunit;
using Moq;
using TradeBookingDependencyInjection;

namespace TradeBookingDependencyInjectionTests
{
    public class TradeConfirmationTest
    {
        [Fact]
        public void TestTradeConfirmation()
        {
            string message;
            var swapMock = new Mock<Swap>();

            var tradeConfirmationMock = new Mock<ITradeConfirmation>();
            tradeConfirmationMock.Setup(m => m.SendTradeConfirmationTicket(swapMock.Object, out message));

            Assert.NotNull(swapMock.Object);

        }
    }
}
