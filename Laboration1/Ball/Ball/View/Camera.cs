using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Ball.View
{
    class Camera
    {

        float scaleX;
        float scaleY;
        int borderSize = 30;
        public Camera(Viewport viewPort)
        {
            scaleX = viewPort.Width;
            scaleY = viewPort.Height;

            if (scaleX < scaleY)
            {
                scaleY = scaleX;
            }
            else if (scaleY < scaleX)
            {
                scaleX = scaleY;
            }

            scaleX = scaleX - borderSize * 2;
            scaleY = scaleY - borderSize * 2;
        }

        public Rectangle getRectangle()
        {
            return new Rectangle(borderSize, borderSize, (int)scaleX, (int)scaleY);
        }

        public Vector2 convertToVisualCoords(Vector2 cords)
        {
            int visualX = (int)(cords.X * scaleX) + borderSize;
            int visualY = (int)(cords.Y * scaleY) + borderSize;

            return new Vector2(visualX, visualY);
        }

        public float getBallScale(float radius, int ballWidth)
        {
            return (radius * 2) * scaleX / ballWidth;
        }
    }
}
