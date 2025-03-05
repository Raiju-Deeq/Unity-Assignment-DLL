using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayDLL
{
    public class Shield : ICollectable
    {
        public void ApplyEffect(IPlayer player)
        {
            player.ApplyPowerUp(PowerUpType.Shield, 15f);
        }

        public int GetScoreValue() => 0; // No score for collecting

        public PowerUpType GetPowerUpType() => PowerUpType.Shield;
    }
}
