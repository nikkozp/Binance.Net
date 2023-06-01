using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Binance.Net.Objects.Models.Futures.Socket
{
    /// <summary>
    /// Update when a triggered TP/SL order got rejected
    /// </summary>
    public class BinanceTriggerOrderRejectUpdated : BinanceStreamEvent
    {
        /// <summary>
        /// Update info
        /// </summary>
        [JsonProperty("or")]
        public BinanceTriggerOrderReject TrigerOrderReject { get; set; } = null!;
    }

    /// <summary>
    /// Triggered TP/SL order rejected info
    /// </summary>
    public class BinanceTriggerOrderReject
    {
        /// <summary>
        /// Symbol
        /// </summary>
        [JsonProperty("s")]
        public string Symbol { get; set; }

        /// <summary>
        /// OrderId
        /// </summary>
        [JsonProperty("i")]
        public long OrderId { get; set; }

        /// <summary>
        /// Reason
        /// </summary>
        [JsonProperty("r")]
        public string Reason { get; set; }
    }
}
