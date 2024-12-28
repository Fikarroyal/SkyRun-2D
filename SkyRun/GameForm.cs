using System;
using System.Drawing;
using System.Windows.Forms;

namespace SkyRun
{
    public partial class GameForm : Form
    {
        private Player player;
        private Obstacle obstacle;
        private Timer gameTimer;
        private int score;

        public GameForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeGame();
        }

        private void InitializeGame()
        {
            score = 0;
            player = new Player(new Point(100, ClientSize.Height - 80));
            obstacle = new Obstacle(new Point(ClientSize.Width, ClientSize.Height - 80));
            gameTimer = new Timer
            {
                Interval = 20
            };
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            obstacle.Move();
            if (obstacle.Position.X < 0)
            {
                obstacle.Reset(ClientSize.Width, ClientSize.Height - 80);
                score++;
            }

            if (player.Bounds.IntersectsWith(obstacle.Bounds))
            {
                gameTimer.Stop();
                MessageBox.Show("Game Over\nYour Score: " + score, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(Color.CornflowerBlue);

            player.Draw(e.Graphics);
            obstacle.Draw(e.Graphics);

            // Display score
            e.Graphics.DrawString("Score: " + score, new Font("Arial", 16), Brushes.White, new Point(10, 10));
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Up)
                player.Jump();
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (e.KeyCode == Keys.Up)
                player.StopJumping();
        }
    }
}
