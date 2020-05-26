using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;


namespace TradeBookingDependencyInjection
{
    public class ContainerBuilder
    {
        public IServiceProvider Build()
        {
            var container = new ServiceCollection();
            container.AddSingleton<ITradeProcessor, TradeProcessor>();
            container.AddSingleton<ITradeReporting, TradeReporting>();
            container.AddSingleton<ITradeConfirmation, TradeConfirmation>();
            container.AddSingleton<ITradeRepository, TradeRepository>();

            return container.BuildServiceProvider();
        }
    }
}
