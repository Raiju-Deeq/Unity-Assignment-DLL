using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayDLL
{
    /// <summary>
    /// Defines the contract for the player in the game.
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// Applies a power-up effect to the player.
        /// </summary>
        /// <param name="type">The type of power-up.</param>
        /// <param name="duration">The duration of the power-up effect.</param>
        void ApplyPowerUp(PowerUpType type, float duration);
    }
}
