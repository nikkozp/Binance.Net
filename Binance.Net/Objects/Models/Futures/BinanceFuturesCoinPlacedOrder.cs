using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Binance.Net.Objects.Models.Futures
{
    /// <summary>
    /// The result of placing a new order
    /// </summary>
    public class BinanceFuturesCoinPlacedOrder : BinanceFuturesPlacedOrder
    {
        /// <summary>
        /// Cumulative quantity in quote asset ( for Coin futures )
        /// </summary>
        [JsonProperty("cumBase")]
        public decimal BaseQuantityFilled { get; set; }
    }
}
