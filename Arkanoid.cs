using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Arkanoid.Scenes;
using System;

namespace Arkanoid;

public class Arkanoid : Game
{
  private GraphicsDeviceManager _graphics;
  private SpriteBatch _spriteBatch;

  private SceneManager _sceneManager;

  public Arkanoid()
  {
    _graphics = new GraphicsDeviceManager(this);
    Content.RootDirectory = "Content";
    IsMouseVisible = true;

    // _graphics.IsFullScreen = true;
    // _graphics.ApplyChanges();

    IsFixedTimeStep = false;

  }

  protected override void Initialize()
  {

    Console.WriteLine("Arkanoid::Initialize");

    _sceneManager = new SceneManager();
    _sceneManager.SetScene(new TitleScene());

    base.Initialize();
  }

  protected override void LoadContent()
  {
    Console.WriteLine("Arkanoid::LoadContent");

    _spriteBatch = new SpriteBatch(GraphicsDevice);

    // TODO: use this.Content to load your game content here
    // this.Content.Load<Texture2D>("ball");
  }

  protected override void Update(GameTime gameTime)
  {
    if (Keyboard.GetState().IsKeyDown(Keys.Escape))
      Exit();

    float frameRate = 1 / (float)gameTime.ElapsedGameTime.TotalSeconds;
    Console.WriteLine("Arkanoid::Update - frameRate: " + frameRate);
    // _sceneManager.Update(gameTime);
    base.Update(gameTime);
  }

  protected override void Draw(GameTime gameTime)
  {
    GraphicsDevice.Clear(Color.CornflowerBlue);
    // _sceneManager.Draw(gameTime);
    base.Draw(gameTime);
  }
}
