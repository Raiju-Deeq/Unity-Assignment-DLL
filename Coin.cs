using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayDLL
{
    public class Coin : ICollectable
    {
        public void ApplyEffect(IPlayer player)
        {
            // The coin doesn't apply any effect to the player
        }

        public int GetScoreValue() => 10;

        public PowerUpType GetPowerUpType() => PowerUpType.Coin;
    }
}
