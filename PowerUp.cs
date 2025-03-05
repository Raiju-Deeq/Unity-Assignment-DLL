using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayDLL
{
    /// <summary>
    /// Abstract base class for all power-ups in the game including the coin pickup.
    /// </summary>
    public abstract class PowerUp : ICollectable
    {
        protected PowerUpType type;
        protected float duration;
        protected int scoreValue;

        /// <summary>
        /// Initializes a new instance of the PowerUp class.
        /// </summary>
        /// <param name="type">The type of power-up.</param>
        /// <param name="duration">The duration of the power-up effect.</param>
        /// <param name="scoreValue">The score value of collecting this power-up.</param>
        protected PowerUp(PowerUpType type, float duration, int scoreValue)
        {
            this.type = type;
            this.duration = duration;
            this.scoreValue = scoreValue;
        }

        /// <summary>
        /// Applies the power-up effect to the player.
        /// </summary>
        /// <param name="player">The player to apply the effect to.</param>
        public virtual void ApplyEffect(IPlayer player)
        {
            player.ApplyPowerUp(type, duration);
        }

        /// <summary>
        /// Gets the score value for collecting this power-up.
        /// </summary>
        /// <returns>The score value.</returns>
        public virtual int GetScoreValue() => scoreValue;

        /// <summary>
        /// Gets the type of this power-up.
        /// </summary>
        /// <returns>The PowerUpType of this power-up.</returns>
        public PowerUpType GetPowerUpType() => type;
    }

    /// <summary>
    /// Represents a double points power-up.
    /// </summary>
    public class DoublePoints : PowerUp
    {
        /// <summary>
        /// Initializes a new instance of the DoublePoints class.
        /// </summary>
        public DoublePoints() : base(PowerUpType.DoublePoints, 20f, 0) { }
    }

    /// <summary>
    /// Represents a speed boost power-up.
    /// </summary>
    public class SpeedBoost : PowerUp
    {
        /// <summary>
        /// Initializes a new instance of the SpeedBoost class.
        /// </summary>
        public SpeedBoost() : base(PowerUpType.SpeedBoost, 10f, 0) { }
    }

    /// <summary>
    /// Represents a shield power-up.
    /// </summary>
    public class Shield : PowerUp
    {
        /// <summary>
        /// Initializes a new instance of the Shield class.
        /// </summary>
        public Shield() : base(PowerUpType.Shield, 15f, 0) { }
    }

    /// <summary>
    /// Represents a coin collectible.
    /// </summary>
    public class Coin : PowerUp
    {
        /// <summary>
        /// Initializes a new instance of the Coin class.
        /// </summary>
        public Coin() : base(PowerUpType.Coin, 0f, 10) { }

        /// <summary>
        /// Overrides the ApplyEffect method as coins don't apply any effect to the player.
        /// </summary>
        /// <param name="player">The player collecting the coin.</param>
        public override void ApplyEffect(IPlayer player)
        {
            // The coin doesn't apply any effect to the player
        }
    }
}
