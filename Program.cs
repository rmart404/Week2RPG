using System;

using RPG;

Player Ray = new();

Dragon Smaug = new();

Goblin Nobody = new();

Ogre Another = new();

Console.WriteLine(Ray.hitPower);

for (var i = 0; i < 3; i++)
{
  Ray.hit(Smaug);
}

Ray.hit(Nobody);


Ray.levelUp();

Ray.hit(Smaug);
Ray.hit(Smaug);
Ray.hit(Smaug);

Ray.hit(Nobody);

Ray.hit(Another);
Ray.hit(Another);