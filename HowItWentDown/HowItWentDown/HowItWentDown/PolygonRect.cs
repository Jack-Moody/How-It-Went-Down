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
        public PolygonRect()
        {
            vertices = new VertexPositionColorTexture[6];
            vertices[0] = new VertexPositionColorTexture(new Vector3(0, 0, 0), Color.White, Vector2.Zero);
            vertices[1] = new VertexPositionColorTexture(new Vector3(100, 0, 0), Color.White, new Vector2(100,0));
            vertices[2] = new VertexPositionColorTexture(new Vector3(100, 100, 0), Color.White, new Vector2(100,100));
            vertices[3] = new VertexPositionColorTexture(new Vector3(100, 100, 0), Color.White, new Vector2(100, 100));
            vertices[4] = new VertexPositionColorTexture(new Vector3(0, 100, 0), Color.White, new Vector2(0, 100));
            vertices[5] = new VertexPositionColorTexture(new Vector3(0, 0, 0), Color.White, Vector2.Zero);
        }
    }
}
