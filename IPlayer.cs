namespace GamePlayDLL
{
    /// <summary>
    /// Defines the interface for player characters in the game.
    /// This interface outlines the essential methods that any player implementation should have.
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// Gets the current movement speed of the player.
        /// </summary>
        /// <returns>The player's movement speed as a float.</returns>
        float GetMovementSpeed();

        /// <summary>
        /// Sets the movement speed of the player.
        /// </summary>
        /// <param name="speed">The new movement speed to set.</param>
        void SetMovementSpeed(float speed);

        /// <summary>
        /// Checks if the player is currently invulnerable.
        /// </summary>
        /// <returns>True if the player is invulnerable, false otherwise.</returns>
        bool IsInvulnerable();

        /// <summary>
        /// Sets the invulnerability state of the player.
        /// </summary>
        /// <param name="invulnerable">True to make the player invulnerable, false to make them vulnerable.</param>
        void SetInvulnerable(bool invulnerable);

        /// <summary>
        /// Gets the current score multiplier of the player.
        /// </summary>
        /// <returns>The player's score multiplier as an integer.</returns>
        int GetScoreMultiplier();

        /// <summary>
        /// Sets the score multiplier for the player.
        /// </summary>
        /// <param name="multiplier">The new score multiplier to set.</param>
        void SetScoreMultiplier(int multiplier);

        /// <summary>
        /// Adds points to the player's score.
        /// </summary>
        /// <param name="points">The number of points to add to the score.</param>
        void AddScore(int points);

        /// <summary>
        /// Gets the current score of the player.
        /// </summary>
        /// <returns>The player's current score as an integer.</returns>
        int GetScore();

        /// <summary>
        /// Applies damage to the player.
        /// </summary>
        /// <param name="damage">The amount of damage to apply to the player.</param>
        void TakeDamage(int damage);
    }
}
