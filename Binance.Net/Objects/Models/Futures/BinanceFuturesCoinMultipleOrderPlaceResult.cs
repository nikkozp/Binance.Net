using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Binance.Net.Objects.Models.Futures
{
    /// <summary>
    /// Extension to be able to deserialize an error response as well
    /// </summary>
    internal class BinanceFuturesCoinMultipleOrderPlaceResult : BinanceFuturesCoinPlacedOrder
    {
        public int Code { get; set; }

        [JsonProperty("msg")]
        public string Message { get; set; } = string.Empty;
    }
}
