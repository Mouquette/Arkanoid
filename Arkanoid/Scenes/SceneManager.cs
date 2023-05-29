using System;
using Microsoft.Xna.Framework;

namespace Arkanoid.Scenes;

public class SceneManager
{
  protected Scene _currentScene;

  public void SetScene(Scene scene)
  {
    Console.WriteLine("SceneManager::SetScene");
    _currentScene = scene;
    _currentScene.Initialize();
  }

  public void Update(GameTime gameTime)
  {
    Console.WriteLine("SceneManager::Update - gameTime: " + gameTime);
    _currentScene.Update(gameTime);
  }

  public void Draw(GameTime gameTime)
  {
    Console.WriteLine("SceneManager::Draw - gameTime: " + gameTime);
    _currentScene.Draw(gameTime);
  }
}
