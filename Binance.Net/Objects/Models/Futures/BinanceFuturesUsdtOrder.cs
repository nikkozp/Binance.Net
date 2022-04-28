using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Binance.Net.Objects.Models.Futures
{
    /// <summary>
    /// The result of query order
    /// </summary>
    public class BinanceFuturesUsdtOrder : BinanceFuturesOrder
    {
        /// <summary>
        /// Cumulative quantity in quote asset ( for USD futures )
        /// </summary>
        [JsonProperty("cumQuote")]
        public decimal QuoteQuantity { get; set; }
    }
}
