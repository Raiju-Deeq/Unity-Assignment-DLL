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
        private bool isDoublePointsActive = false;

        /// <summary>
        /// Adds points to the current score, doubling them if DoublePoints is active.
        /// </summary>
        /// <param name="points">The points to add.</param>
        public void AddScore(int points)
        {
            currentScore += isDoublePointsActive ? points * 2 : points;
        }

        /// <summary>
        /// Gets the current score.
        /// </summary>
        /// <returns>The current score.</returns>
        public int GetCurrentScore() => currentScore;

        /// <summary>
        /// Sets the DoublePoints power-up state.
        /// </summary>
        /// <param name="active">Whether DoublePoints should be active.</param>
        public void SetDoublePointsActive(bool active)
        {
            isDoublePointsActive = active;
        }
    }
}

