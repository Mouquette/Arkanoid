using System;
using Microsoft.Xna.Framework;

namespace Arkanoid.Scenes;

public class GameScene : Scene
{
  public override void Initialize()
  {
    Console.WriteLine("GameScene::Initialize");
    // throw new NotImplementedException();
  }

  public override void Update(GameTime gameTime)
  {
    Console.WriteLine("GameScene::Update - gameTime: " + gameTime);
    // throw new NotImplementedException();
  }

  public override void Draw(GameTime gameTime)
  {
    Console.WriteLine("GameScene::Draw - gameTime: " + gameTime);
    // throw new NotImplementedException();
  }
}