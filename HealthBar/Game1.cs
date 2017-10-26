using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace HealthBar
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private HealthBar _health;

        //public int health;
        //private Texture2D HealthBar; // hold the texture
        //Rectangle _healthRect;   // display the Health bar size
        //Vector2 position;

        //public Rectangle HealthRect
        //{
        //    get
        //    {
        //        return new Rectangle((int)position.X, (int)position.Y , health, _healthRect.Height);
        //    }

        //    set
        //    {
        //        _healthRect = value;
        //    }
        //}

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            _health = new HealthBar(GraphicsDevice);
            //HealthBar = new Texture2D(GraphicsDevice, 1, 1);
            //HealthBar.SetData(new Color[] { Color.White });
            //health = 100;
            //HealthRect = new Rectangle(new Point(100, 100), new Point(100,20 ));
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            _health.Draw(spriteBatch);
            // TODO: Add your drawing code here
            //if (health > 60)
            //    spriteBatch.Draw(HealthBar, HealthRect, Color.Green);
            //else if (health > 30 && health <= 60)
            //    spriteBatch.Draw(HealthBar, HealthRect, Color.Orange);
            //else if (health > 0 && health <= 30)
            //    spriteBatch.Draw(HealthBar, HealthRect, Color.Red);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
