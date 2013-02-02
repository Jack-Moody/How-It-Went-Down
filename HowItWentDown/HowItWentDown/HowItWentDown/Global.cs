using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace HowItWentDown
{
    class Global
    {
        public static Game1 Doc;
        public static Texture2D LoadTexture(string name)
        {
            return Doc.Content.Load<Texture2D>(name);
        }
    }
}
