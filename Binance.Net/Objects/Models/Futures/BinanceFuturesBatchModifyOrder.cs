using Binance.Net.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Binance.Net.Objects.Models.Futures
{
    /// <summary>
    /// Parameters for a modify batch order
    /// </summary>
    public class BinanceFuturesBatchModifyOrder
    {
        /// <summary>
        /// Symbol of the order
        /// </summary>
        public string Symbol { get; set; } = string.Empty;

        /// <summary>
        /// Side of the order
        /// </summary>
        public OrderSide Side { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// A unique id among
        /// </summary>
        public long? OrderId { get; set; } = null;

        /// <summary>
        /// A unique id among order
        /// </summary>
        public string ClientOrderId { get; set; } = null;

        /// <summary>
        /// The receive window for which this request is active. When the request takes longer than this to complete the server will reject the request
        /// </summary>

        public int? ReceiveWindow = null;
    }
}
