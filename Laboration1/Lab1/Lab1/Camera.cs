using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Lab1
{
    class Camera
    {
        private int sizeOfTile = 64;
        private int borderSize = 64;
        private float visualX;
        private float visualY;

        public float scale = 1;

        public Vector2 GetVisualCord(int xCord, int yCord)
        {
            visualX = borderSize + xCord * sizeOfTile;
            visualY = borderSize + yCord * sizeOfTile;

            return new Vector2(visualX, visualY);
        }

        public Vector2 GetRotationOfBoard(int xCord, int yCord)
        {
            visualX = sizeOfTile * 8  - xCord * sizeOfTile;
            visualY = sizeOfTile * 8  - yCord * sizeOfTile;

            return new Vector2(visualX, visualY);
        }

        public void SetScale(GraphicsDeviceManager graphics)
        {
            float scaleX = (float)graphics.GraphicsDevice.Viewport.Width / (sizeOfTile * 8 + borderSize * 2);
            float scaleY = (float)graphics.GraphicsDevice.Viewport.Height / (sizeOfTile * 8 + borderSize * 2);

            if (scaleX < scaleY)
            {
                scale = scaleX;
            }
            else
            {
                scale = scaleY;
            }

            sizeOfTile = Convert.ToInt32(Math.Round(scale * sizeOfTile));
            borderSize = Convert.ToInt32(Math.Round(scale * borderSize));
        }
    }
}
