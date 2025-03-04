using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayDLL
{
    /// <summary>
    /// Manages the scoring system for the game.
    /// </summary>
    public class ScoreManager
    {
        private int currentScore;

        /// <summary>
        /// Adds points to the current score.
        /// </summary>
        /// <param name="points">The points to add.</param>
        public void AddScore(int points) => currentScore += points;

        /// <summary>
        /// Gets the current score.
        /// </summary>
        /// <returns>The current score.</returns>
        public int GetCurrentScore() => currentScore;
    }
}
