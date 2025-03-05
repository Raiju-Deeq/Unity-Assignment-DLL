using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayDLL
{
    /// <summary>
    /// Defines the interface for collectable items in the game.
    /// </summary>
    public interface ICollectable
    {
        /// <summary>
        /// Applies the effect of the collectable to the player.
        /// </summary>
        /// <param name="player">The player to apply the effect to.</param>
        void ApplyEffect(IPlayer player);

        /// <summary>
        /// Gets the score value of the collectable.
        /// </summary>
        /// <returns>The score value.</returns>
        int GetScoreValue();

        /// <summary>
        /// Gets the type of the power-up.
        /// </summary>
        /// <returns>The PowerUpType of this collectable.</returns>
        PowerUpType GetPowerUpType();
    }
}
