using System;
using System.Collections.Generic;
using System.Text;

namespace Binance.Net.Objects.Models.Spot.Margin
{
    /// <summary>
    /// Information regarding a specific order
    /// </summary>
    public class BinanceMarginCanceledOrder : BinanceOrderBase
    {
        /// <summary>
        /// If isolated margin (for margin account orders)
        /// </summary>
        public bool IsIsolated { get; set; }
    }
}
