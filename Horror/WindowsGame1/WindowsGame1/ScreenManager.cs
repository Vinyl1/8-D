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
    public class ScreenManager
    {
        public Vector2 Dimensions { private set; get; } //Resolution
        public ContentManager Content { private set; get; }
        GameScreen CurrentScreen;
        float ElapsedTime; //Used to calculat how long the SplashScreen is displayed to switch to MainMenu
        float Delay = 2250f;
        string Screen { private set; get; }

        public ScreenManager()
        {
            Dimensions = new Vector2(1024, 768);
            CurrentScreen = new SplashScreen();
            Screen = "SplashScreen";
        }

        public void LoadContent(ContentManager Content)
        {
            this.Content = new ContentManager(Content.ServiceProvider, "Content");
            CurrentScreen.LoadContent();
        }

        public void UnloadContent()
        {
            CurrentScreen.UnloadContent();
        }

        public void Update(GameTime gameTime)
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            CurrentScreen.Draw(spriteBatch);
        }

    }
}
