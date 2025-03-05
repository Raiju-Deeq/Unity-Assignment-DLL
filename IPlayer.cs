﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayDLL
{
    /// <summary>
    /// Defines the interface for the player in the game.
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// Applies a power-up effect to the player.
        /// </summary>
        /// <param name="type">The type of power-up.</param>
        /// <param name="duration">The duration of the power-up effect.</param>
        void ApplyPowerUp(PowerUpType type, float duration);

        /// <summary>
        /// Applies damage to the player.
        /// </summary>
        /// <param name="damage">The amount of damage to apply.</param>
        void TakeDamage(int damage);

        /// <summary>
        /// Adds score to the player's total.
        /// </summary>
        /// <param name="points">The number of points to add.</param>
        void AddScore(int points);

        /// <summary>
        /// Gets the player's current score.
        /// </summary>
        /// <returns>The current score.</returns>
        int GetScore();
    }
}
