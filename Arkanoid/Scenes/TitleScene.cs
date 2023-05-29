using System;
using Microsoft.Xna.Framework;

namespace Arkanoid.Scenes;

public class TitleScene : Scene
{
  public override void Initialize()
  {
    Console.WriteLine("TitleScene::Initialize");
    // throw new NotImplementedException();
  }

  public override void Update(GameTime gameTime)
  {
    Console.WriteLine("TitleScene::Update - gameTime: " + gameTime);
    // throw new NotImplementedException();
  }

  public override void Draw(GameTime gameTime)
  {
    Console.WriteLine("TitleScene::Update - gameTime: " + gameTime);
    // throw new NotImplementedException();
  }
}
