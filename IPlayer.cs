namespace GamePlayDLL
{
    public interface IPlayer
    {
        float GetMovementSpeed();
        void SetMovementSpeed(float speed);
        bool IsInvulnerable();
        void SetInvulnerable(bool invulnerable);
        int GetScoreMultiplier();
        void SetScoreMultiplier(int multiplier);
        void AddScore(int points);
        int GetScore();
        void TakeDamage(int damage); // Add this method for handling damage
    }
}
