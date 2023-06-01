﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Binance.Net.Objects.Models.Futures
{
    /// <summary>
    /// The result of placing a new order
    /// </summary>
    public class BinanceFuturesUsdtPlacedOrder : BinanceFuturesPlacedOrder
    {
        /// <summary>
        /// Cumulative quantity in quote asset ( for USD futures )
        /// </summary>
        [JsonProperty("cumQuote")]
        public decimal QuoteQuantityFilled { get; set; }
    }
}