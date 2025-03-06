using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayDLL
{
    public abstract class PowerUpEffect
    {
        public abstract void ApplyEffect(IPlayer player);
        public abstract void RemoveEffect(IPlayer player);
    }

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
