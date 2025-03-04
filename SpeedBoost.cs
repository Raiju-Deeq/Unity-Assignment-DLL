using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayDLL
{
    /// <summary>
    /// Represents a speed boost power-up.
    /// </summary>
    public class SpeedBoost : ICollectable
    {
        /// <summary>
        /// Applies the speed boost effect to the player.
        /// </summary>
        /// <param name="player">The player to apply the effect to.</param>
        public void ApplyEffect(IPlayer player)
        {
            player.ApplyPowerUp(PowerUpType.SpeedBoost, 10f);
        }

        /// <summary>
        /// Gets the score value for collecting this power-up.
        /// </summary>
        /// <returns>The score value.</returns>
        public int GetScoreValue() => 10;

        /// <summary>
        /// Gets the type of this power-up.
        /// </summary>
        /// <returns>The PowerUpType of this power-up.</returns>
        public PowerUpType GetPowerUpType() => PowerUpType.SpeedBoost;
    }
}
