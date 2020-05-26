using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeBookingDependencyInjection
{
    public class Swap
    {
        public String portfolio { get; set; }
        public String currency { get; set; }
        public String swaptype { get; set; }
        public String direction { get; set; }
        public DateTime effectivedate { get; set; }
        public DateTime maturitydate { get; set; }
        public Double fixedrate { get; set; }
        public Double notional { get; set; }
        public int swapidentifier { get; set; }

    }
}
