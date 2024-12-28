namespace SkyRun
{
    public class ScoreManager
    {
        public int Score { get; private set; }

        public void IncrementScore()
        {
            Score++;
        }

        public void ResetScore()
        {
            Score = 0;
        }
    }
}
