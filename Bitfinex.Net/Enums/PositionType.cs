﻿using CryptoExchange.Net.Attributes;

namespace Bitfinex.Net.Enums
{
    /// <summary>
    /// Type of position
    /// </summary>
    public enum PositionType
    {
        /// <summary>
        /// Margin position
        /// </summary>
        [Map("0")]
        MarginPosition,
        /// <summary>
        /// Derivatives position
        /// </summary>
        [Map("1")]
        DerivativesPosition
    }
}
