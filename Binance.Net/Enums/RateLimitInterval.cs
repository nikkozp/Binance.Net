namespace Binance.Net.Enums
{
    /// <summary>
    /// Rate limit on what unit
    /// </summary>
    public enum RateLimitInterval
    {
        /// <summary>
        /// Seconds
        /// </summary>
        Second = 1,
        /// <summary>
        /// Minutes
        /// </summary>
        Minute = 1 * 60,
        /// <summary>
        /// Days
        /// </summary>
        Day = 1 * 60 * 60 * 24
    }
}
