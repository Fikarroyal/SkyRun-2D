using System;
using System.Drawing;

namespace SkyRun
{
    public class Obstacle
    {
        public Point Position { get; set; }
        public Rectangle Bounds => new Rectangle(Position, new Size(50, 50));

        public Obstacle(Point startPosition)
        {
            Position = startPosition;
        }

        public void Move()
        {
            Position = new Point(Position.X - 5, Position.Y);
        }

        public void Reset(int x, int y)
        {
            Position = new Point(x, y);
        }

        public void Draw(Graphics g)
        {
            Image obstacleImage = Image.FromFile("Assets/obstacle.png");
            g.DrawImage(obstacleImage, Bounds);
        }
    }
}
