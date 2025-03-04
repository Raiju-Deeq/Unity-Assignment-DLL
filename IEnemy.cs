using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayDLL
{
    /// <summary>
    /// Defines the contract for enemies in the game.
    /// </summary>
    public interface IEnemy
    {
        /// <summary>
        /// Performs an attack on the player.
        /// </summary>
        /// <param name="player">The player to attack.</param>
        void Attack(IPlayer player);
    }
}
