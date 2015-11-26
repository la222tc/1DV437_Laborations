using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Ball.Model
{
    class Ball
    {
        private float radius = 0.05f;
        Vector2 ballPosition;
        Vector2 ballSpeed = new Vector2(0.5f, 0.8f);
        Random random = new Random();
        

        public Ball()
        {
            ballPosition = new Vector2(0.4f, 0.8f);
        }
        public float getBallRadius
        {
            get
            {
                return radius;
            }
        }

        public Vector2 getBallPosition
        {
            get
            {
                return ballPosition;
            }
            
        }

        public void setNewBallSpeedX()
        {
            ballSpeed.X = -ballSpeed.X;
        }

        public void setNewBallSpeedY()
        {
            ballSpeed.Y = -ballSpeed.Y;
        }
        public void UpdateBallPosition(float gameTime)
        {
            ballPosition.X += ballSpeed.X * gameTime;
            ballPosition.Y += ballSpeed.Y * gameTime;
        }

    }
}
