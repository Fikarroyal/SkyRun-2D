using System.Drawing;

namespace SkyRun
{
    public class Player
    {
        public Point Position { get; set; }
        public Rectangle Bounds => new Rectangle(Position, new Size(50, 50));
        private bool isJumping;
        private int jumpHeight;

        public Player(Point startPosition)
        {
            Position = startPosition;
            isJumping = false;
            jumpHeight = 0;
        }

        public void Move(int deltaX, int deltaY)
        {
            Position = new Point(Position.X + deltaX, Position.Y + deltaY);
        }

        public void Jump()
        {
            if (!isJumping)
            {
                isJumping = true;
                jumpHeight = 20;
            }
        }

        public void StopJumping()
        {
            isJumping = false;
            jumpHeight = 0;
        }

        public void Draw(Graphics g)
        {
            Image playerImage = Image.FromFile("Assets/player.png");
            g.DrawImage(playerImage, Bounds);
            if (isJumping)
            {
                Position = new Point(Position.X, Position.Y - jumpHeight);
            }
            else
            {
                if (Position.Y < 500) Position = new Point(Position.X, Position.Y + 5);
            }
        }
    }
}
