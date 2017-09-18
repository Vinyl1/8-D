using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace WindowsGame1
{
    class SplashScreen : GameScreen
    {
        Texture2D splashScreen;
        string Path;
        public override void LoadContent()
        {
            base.LoadContent();
            Path = "GameScreens/SplashScreen";
            splashScreen = content.Load<Texture2D>(Path);
        }
        public override void UnloadContent()
        {
            base.UnloadContent();
            content.Unload();
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(splashScreen, Vector2.Zero, Color.White);
        }
    }
}
