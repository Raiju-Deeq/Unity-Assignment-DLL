using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayDLL
{
    public abstract class PowerUp : ICollectable
    {
        protected PowerUpType type;
        protected float duration;
        protected int scoreValue;

        protected PowerUp(PowerUpType type, float duration, int scoreValue)
        {
            this.type = type;
            this.duration = duration;
            this.scoreValue = scoreValue;
        }

        public virtual void ApplyEffect(IPlayer player)
        {
            player.ApplyPowerUp(type, duration);
        }

        public virtual int GetScoreValue() => scoreValue;
        public PowerUpType GetPowerUpType() => type;
    }

    public class DoublePoints : PowerUp
    {
        public DoublePoints() : base(PowerUpType.DoublePoints, 20f, 0) { }
    }

    public class SpeedBoost : PowerUp
    {
        public SpeedBoost() : base(PowerUpType.SpeedBoost, 10f, 0) { }
    }

    public class Shield : PowerUp
    {
        public Shield() : base(PowerUpType.Shield, 15f, 0) { }
    }

    public class Coin : PowerUp
    {
        public Coin() : base(PowerUpType.Coin, 0f, 10) { }

        public override void ApplyEffect(IPlayer player)
        {
            // The coin doesn't apply any effect to the player
        }
    }
}
