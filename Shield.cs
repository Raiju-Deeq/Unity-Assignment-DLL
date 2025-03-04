using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayDLL
{
    /// <summary>
    /// Represents a shield power-up.
    /// </summary>
    public class Shield : ICollectable
    {
        /// <summary>
        /// Applies the shield effect to the player.
        /// </summary>
        /// <param name="player">The player to apply the effect to.</param>
        public void ApplyEffect(IPlayer player)
        {
            player.ApplyPowerUp(PowerUpType.Shield, 15f);
        }

        /// <summary>
        /// Gets the score value for collecting this power-up.
        /// </summary>
        /// <returns>The score value.</returns>
        public int GetScoreValue() => 15;
    }
}
