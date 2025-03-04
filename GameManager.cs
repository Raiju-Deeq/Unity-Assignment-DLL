using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace GamePlayDLL
{
    /// <summary>
    /// Manages the overall game state and interactions.
    /// </summary>
    public class GameManager
    {
        private ScoreManager scoreManager;
        private SpawningManager spawningManager;

        /// <summary>
        /// Initializes a new instance of the GameManager class.
        /// </summary>
        public GameManager()
        {
            scoreManager = new ScoreManager();
            spawningManager = new SpawningManager();
        }

        /// <summary>
        /// Starts the game.
        /// </summary>
        public void StartGame() => Debug.Log("Game Started");

        /// <summary>
        /// Pauses the game.
        /// </summary>
        public void PauseGame() => Debug.Log("Game Paused");

        /// <summary>
        /// Ends the game.
        /// </summary>
        public void EndGame() => Debug.Log("Game Over");

        /// <summary>
        /// Gets the current score.
        /// </summary>
        /// <returns>The current score.</returns>
        public int GetCurrentScore() => scoreManager.GetCurrentScore();

        /// <summary>
        /// Gets a spawn position within the specified bounds.
        /// </summary>
        /// <param name="prefab">The prefab to spawn.</param>
        /// <param name="minPosition">The minimum position for spawning.</param>
        /// <param name="maxPosition">The maximum position for spawning.</param>
        /// <returns>The spawned GameObject.</returns>
        public GameObject SpawnObject(GameObject prefab, Vector3 minPosition, Vector3 maxPosition)
        {
            return spawningManager.Spawn(prefab, minPosition, maxPosition);
        }

        /// <summary>
        /// Handles the collection of a power-up by the player.
        /// </summary>
        /// <param name="powerUp">The power-up collected.</param>
        /// <param name="player">The player who collected the power-up.</param>
        public void CollectPowerUp(ICollectable powerUp, IPlayer player)
        {
            powerUp.ApplyEffect(player);
            scoreManager.AddScore(powerUp.GetScoreValue());
        }
    }
}
