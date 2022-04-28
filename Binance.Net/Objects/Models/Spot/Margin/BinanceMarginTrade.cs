using System;
using System.Collections.Generic;
using System.Text;

namespace Binance.Net.Objects.Models.Spot.Margin
{
    /// <summary>
    /// Information about a trade
    /// </summary>
    public class BinanceMarginTrade : BinanceTrade
    {
        /// <summary>
        /// If isolated margin (for margin account orders)
        /// </summary>
        public bool IsIsolated { get; set; }
    }
}
