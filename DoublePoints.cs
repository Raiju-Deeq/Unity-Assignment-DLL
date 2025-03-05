using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayDLL
{
    public class DoublePoints : ICollectable
    {
        public void ApplyEffect(IPlayer player)
        {
            player.ApplyPowerUp(PowerUpType.DoublePoints, 20f);
        }

        public int GetScoreValue() => 0; // No score for collecting

        public PowerUpType GetPowerUpType() => PowerUpType.DoublePoints;
    }
}
