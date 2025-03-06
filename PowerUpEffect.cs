using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayDLL
{
    /// <summary>
    /// Abstract base class for all power-up effects in the game.
    /// Defines the structure for applying and removing effects on the player.
    /// </summary>
    public abstract class PowerUpEffect
    {
        /// <summary>
        /// Applies the power-up effect to the player.
        /// </summary>
        /// <param name="player">The player to apply the effect to.</param>
        public abstract void ApplyEffect(IPlayer player);

        /// <summary>
        /// Removes the power-up effect from the player.
        /// </summary>
        /// <param name="player">The player to remove the effect from.</param>
        public abstract void RemoveEffect(IPlayer player);
    }

    /// <summary>
    /// Represents a speed boost power-up effect.
    /// Increases the player's movement speed by 50%.
    /// </summary>
    public class SpeedBoostEffect : PowerUpEffect
    {
        public override void ApplyEffect(IPlayer player)
        {
            player.SetMovementSpeed(player.GetMovementSpeed() * 1.5f);
        }

        public override void RemoveEffect(IPlayer player)
        {
            player.SetMovementSpeed(player.GetMovementSpeed() / 1.5f);
        }
    }

    /// <summary>
    /// Represents a shield power-up effect.
    /// Makes the player invulnerable to damage.
    /// </summary>
    public class ShieldEffect : PowerUpEffect
    {
        public override void ApplyEffect(IPlayer player)
        {
            player.SetInvulnerable(true);
        }

        public override void RemoveEffect(IPlayer player)
        {
            player.SetInvulnerable(false);
        }
    }

    /// <summary>
    /// Represents a double points power-up effect.
    /// Doubles the score multiplier for the player.
    /// </summary>
    public class DoublePointsEffect : PowerUpEffect
    {
        public override void ApplyEffect(IPlayer player)
        {
            player.SetScoreMultiplier(2);
        }

        public override void RemoveEffect(IPlayer player)
        {
            player.SetScoreMultiplier(1);
        }
    }

    /// <summary>
    /// Represents a coin power-up effect.
    /// Instantly adds 100 points to the player's score.
    /// </summary>
    public class CoinEffect : PowerUpEffect
    {
        public override void ApplyEffect(IPlayer player)
        {
            player.AddScore(100);
        }

        public override void RemoveEffect(IPlayer player)
        {
            // No need to remove effect for instant power-ups
        }
    }
}
