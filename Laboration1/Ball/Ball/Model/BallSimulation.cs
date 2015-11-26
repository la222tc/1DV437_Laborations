using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Ball.Model
{
    class BallSimulation
    {
        Ball ball = new Ball();

        public Vector2 getBallPosition()
        {
            return ball.getBallPosition;
        }

        public float getBallRadius()
        {
            return ball.getBallRadius;
        }

        public void Update(float gameTime)
        {
            ball.UpdateBallPosition(gameTime);

            if (getBallPosition().X + getBallRadius() >= 1 || getBallPosition().X - getBallRadius() <= 0)
            {
                ball.setNewBallSpeedX();
            }

            if (getBallPosition().Y + getBallRadius() >= 1 || getBallPosition().Y - getBallRadius() <= 0)
            {
                ball.setNewBallSpeedY();
            }
        }
    }
}
