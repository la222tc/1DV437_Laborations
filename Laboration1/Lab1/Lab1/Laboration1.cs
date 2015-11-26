using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Lab1
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Laboration1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D whiteBrick;
        Texture2D blackBrick;
        Texture2D player;
        Camera camera;

        public Laboration1()
        {
            camera = new Camera();
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 320;
            graphics.PreferredBackBufferHeight = 240;
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

            // TODO: use this.Content to load your game content here
            whiteBrick = Content.Load<Texture2D>("whiteBox.png");
            blackBrick = Content.Load<Texture2D>("blackBox.png");
            player = Content.Load<Texture2D>("player.png");
            camera.SetScale(graphics);
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

            // TODO: Add your drawing code here

            spriteBatch.Begin();

            int c = 0;

            for (int x = 0; x < 8; x++)
            {
                 for (int y = 0; y < 8; y++)
                 {
                     if (c % 2 == 0)
                     {
                         spriteBatch.Draw(whiteBrick, camera.GetVisualCord(x, y), null, Color.White,
                                         0, new Vector2(0,0), camera.scale, SpriteEffects.None, 0);
                     }
                     else
                     {
                         spriteBatch.Draw(blackBrick, camera.GetVisualCord(x, y), null, Color.White, 
                                         0, new Vector2(0, 0), camera.scale, SpriteEffects.None, 0);
                     }
                     c++;
                 }
                 c++;
            }

            //spriteBatch.Draw(player, camera.GetRotationOfBoard(1, 1), Color.White);
            spriteBatch.Draw(player, camera.GetRotationOfBoard(4, 4), null, Color.White,
                            0, new Vector2(0, 0), camera.scale, SpriteEffects.None, 0);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
