using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Binance.Net.Objects.Models.Futures
{
    /// <summary>
    /// The result of cancel order
    /// </summary>
    public class BinanceFuturesCoinCancelOrder : BinanceFuturesCancelOrder
    {
        /// <summary>
        /// Cumulative quantity in quote asset ( for Coin futures )
        /// </summary>
        [JsonProperty("cumBase")]
        public decimal BaseQuantityFilled { get; set; }
    }
}
