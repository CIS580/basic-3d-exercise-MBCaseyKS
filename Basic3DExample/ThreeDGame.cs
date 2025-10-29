using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Basic3DExample
{
    public class ThreeDGame : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        // The triangle to draw
        Triangle triangle;

        // The quad to draw
        Quad quad;

        // The cube to draw 
        Cube cube;

        public ThreeDGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // Create the triangle
            triangle = new Triangle(this);

            // Create the quad
            quad = new Quad(this);

            // Create the cube
            cube = new Cube(this);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Update the triangle 
            triangle.Update(gameTime);

            // update the cube 
            cube.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // Draw the triangle 
            triangle.Draw();

            // Draw the quad
            quad.Draw();

            // draw the cube
            cube.Draw();

            base.Draw(gameTime);
        }
    }
}
