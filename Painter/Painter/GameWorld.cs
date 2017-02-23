using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Painter
{
    class GameWorld
    {
        public Texture2D background;
        public Cannon cannon;

        public GameWorld(ContentManager content)
        {
            background = content.Load<Texture2D>("spr_background");
            cannon = new Cannon(content);
        }

        public Cannon Cannon
        {
            get { return cannon; }
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(background, Vector2.Zero, Color.White);
            cannon.Draw(gameTime, spriteBatch);
            spriteBatch.End();
        }
    }

}
