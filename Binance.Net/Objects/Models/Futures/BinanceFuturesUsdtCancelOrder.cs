using Newtonsoft.Json;

namespace Binance.Net.Objects.Models.Futures
{
    /// <summary>
    /// The result of cancel order
    /// </summary>
    public class BinanceFuturesUsdtCancelOrder : BinanceFuturesCancelOrder
    {
        /// <summary>
        /// Cumulative quantity in quote asset ( for USD futures )
        /// </summary>
        [JsonProperty("cumQuote")]
        public decimal QuoteQuantityFilled { get; set; }
    }
}
