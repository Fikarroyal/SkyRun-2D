using System;

namespace SkyRun
{
    public class GameTimer
    {
        public event EventHandler Tick;
        private readonly System.Windows.Forms.Timer timer;

        public GameTimer()
        {
            timer = new System.Windows.Forms.Timer
            {
                Interval = 20
            };
            timer.Tick += (sender, e) => Tick?.Invoke(sender, e);
        }

        public void Start() => timer.Start();
        public void Stop() => timer.Stop();
    }
}
