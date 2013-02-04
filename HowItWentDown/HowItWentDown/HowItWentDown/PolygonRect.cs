using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace HowItWentDown
{
    class PolygonRect
    {
        public Vector2 pos;
        public VertexPositionColorTexture[] vertices;
        float x = 0, y = 0, z = 0, width = 0, height = 0;
        Texture2D tex;
        public PolygonRect(float X, float Y, float Z, float Width, float Height, Texture2D tex)
        {
            vertices = new VertexPositionColorTexture[6];
            vertices[0] = new VertexPositionColorTexture(new Vector3(X, Y, Z), Color.White, Vector2.Zero);
            vertices[1] = new VertexPositionColorTexture(new Vector3(X + Width, Y, Z), Color.White, new Vector2(1,0));
            vertices[2] = new VertexPositionColorTexture(new Vector3(X + Width, Y + Height, Z), Color.White, new Vector2(1,1));
            vertices[3] = new VertexPositionColorTexture(new Vector3(X + Width, Y + Height, Z), Color.White, new Vector2(1, 1));
            vertices[4] = new VertexPositionColorTexture(new Vector3(X, Y + Height, Z), Color.White, new Vector2(0, 1));
            vertices[5] = new VertexPositionColorTexture(new Vector3(X, Y, Z), Color.White, Vector2.Zero);
        }
    }
}
