using System;
using System.Collections.Generic;
using System.Text;

namespace Binance.Net.Objects.Models.Spot.Margin
{
    /// <summary>
    /// Order info
    /// </summary>
    public class BinanceMarginOrder : BinanceOrderBase
    {
        /// <summary>
        /// If isolated margin (for margin account orders)
        /// </summary>
        public bool IsIsolated { get; set; }
    }
}
