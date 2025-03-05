using System;

namespace GamePlayDLL
{
    /// <summary>
    /// enum of the types of power-ups available in the game.
    /// </summary>
    public enum PowerUpType
    {
        /// <summary>
        /// a power-up that increases the player's speed.
        /// </summary>
        SpeedBoost,

        /// <summary>
        /// a power-up that grants the player a shield for protection.
        /// </summary>
        Shield,

        /// <summary>
        /// a power-up that doubles the player's score for a limited time.
        /// </summary>
        DoublePoints,

        /// <summary>
        ///  a collectible coin that adds points to the player's score.
        /// </summary>
        Coin
    }
}
