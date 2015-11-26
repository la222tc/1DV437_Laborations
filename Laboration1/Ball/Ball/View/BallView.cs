using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Ball.Model;

namespace Ball.View
{
    class BallView
    {
        BallSimulation ballSimulation;
        Camera camera;
        Texture2D ballTexture;
        Texture2D backGroundTexture;


        public BallView(BallSimulation Ballsimulation, Camera Camera, GraphicsDevice Graphics, Texture2D BallTexture)
        {
            ballSimulation = Ballsimulation;
            camera = Camera;
            ballTexture = BallTexture;
            backGroundTexture = new Texture2D(Graphics, 1, 1);
            backGroundTexture.SetData(new[] { Color.White });
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            float ballScale = camera.getBallScale(ballSimulation.getBallRadius(), ballTexture.Bounds.Width);

            spriteBatch.Begin();

            spriteBatch.Draw(backGroundTexture, camera.getRectangle(), Color.White);
            spriteBatch.Draw(ballTexture, camera.convertToVisualCoords(ballSimulation.getBallPosition()),
                        ballTexture.Bounds, Color.White, 0, new Vector2(ballTexture.Bounds.Width / 2, ballTexture.Bounds.Height / 2),
                        ballScale, SpriteEffects.None, 0);

            spriteBatch.End();
        }
    }
}
