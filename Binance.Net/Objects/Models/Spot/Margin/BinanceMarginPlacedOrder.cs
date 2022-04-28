using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Binance.Net.Objects.Models.Spot.Margin
{
    /// <summary>
    /// The result of placing a new order
    /// </summary>
    public class BinanceMarginPlacedOrder : BinancePlacedOrder
    {
        /// <summary>
        /// Only present if a margin trade happened
        /// </summary>
        [JsonProperty("marginBuyBorrowAmount")]
        public decimal MarginBuyBorrowQuantity { get; set; }
        /// <summary>
        /// Only present if a margin trade happened
        /// </summary>
        public string MarginBuyBorrowAsset { get; set; }
    }
}
