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
        public Ball ball;
        public PaintCan can1;
        public PaintCan can2;
        public PaintCan can3;

        public GameWorld(ContentManager content)
        {
            background = content.Load<Texture2D>("spr_background");
            cannon = new Cannon(content);
            ball = new Ball(content);
            ball.Reset();
            can1 = new PaintCan(content, 450.0f, Color.Red);
            can2 = new PaintCan(content, 575.0f, Color.Green);
            can3 = new PaintCan(content, 700.0f, Color.Blue);

        }

        public Cannon Cannon
        {
            get { return cannon; }
        }

        public Ball Ball
        {
            get { return ball; }
        }

        public void HandleInput(InputHelper inputHelper)
        {
            cannon.HandleInput(inputHelper);
            ball.HandleInput(inputHelper);
        }

        public void Reset()
        {
            cannon.Reset();
            ball.Reset();
            can1.Reset();
            can2.Reset();
            can3.Reset();
        }

        public bool IsOutsideWorld(Vector2 position)
        {
            return position.X < 0 || position.X > Painter.Screen.X || position.Y > Painter.Screen.Y;
        }

        public void Update(GameTime gameTime)
        {
            ball.Update(gameTime);
            can1.Update(gameTime);
            can2.Update(gameTime);
            can3.Update(gameTime);
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(background, Vector2.Zero, Color.White);
            ball.Draw(gameTime, spriteBatch);
            cannon.Draw(gameTime, spriteBatch);
            can1.Draw(gameTime, spriteBatch);
            can2.Draw(gameTime, spriteBatch);
            can3.Draw(gameTime, spriteBatch);
            spriteBatch.End();
        }
    }

}
