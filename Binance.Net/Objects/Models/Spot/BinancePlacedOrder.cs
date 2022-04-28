﻿using System;
using System.Collections.Generic;
using CryptoExchange.Net.Converters;
using Newtonsoft.Json;

namespace Binance.Net.Objects.Models.Spot
{
    /// <summary>
    /// The result of placing a new order
    /// </summary>
    public class BinancePlacedOrder: BinanceOrderBase
    {
        /// <summary>
        /// The time the order was placed
        /// </summary>
        [JsonProperty("transactTime"), JsonConverter(typeof(DateTimeConverter))]
        public new DateTime CreateTime { get; set; }
        
        /// <summary>
        /// Trades for the order
        /// </summary>
        [JsonProperty("fills")]
        public IEnumerable<BinanceOrderTrade>? Trades { get; set; }
    }
}
