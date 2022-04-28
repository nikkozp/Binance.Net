using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Binance.Net.Objects.Models.Futures
{
    /// <summary>
    /// The result of query order
    /// </summary>
    public class BinanceFuturesCoinOrder : BinanceFuturesOrder
    {
        /// <summary>
        /// Cumulative quantity in quote asset ( for Coin futures )
        /// </summary>
        [JsonProperty("cumBase")]
        public decimal BaseQuantity { get; set; }
    }
}
