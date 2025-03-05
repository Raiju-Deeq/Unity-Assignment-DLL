using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayDLL
{
    public class SpeedBoost : ICollectable
    {
        public void ApplyEffect(IPlayer player)
        {
            player.ApplyPowerUp(PowerUpType.SpeedBoost, 10f);
        }

        public int GetScoreValue() => 0; // No score for collecting

        public PowerUpType GetPowerUpType() => PowerUpType.SpeedBoost;
    }
}
