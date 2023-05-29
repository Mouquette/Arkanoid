using System.Collections;
using Microsoft.Xna.Framework;

namespace Arkanoid.Scenes;

public abstract class Scene
{
  public abstract void Initialize();
  public abstract void Update(GameTime gameTime);
  public abstract void Draw(GameTime gameTime);
}
