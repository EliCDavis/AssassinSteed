using UnityEngine;
using AssassinSteed.Level;
using AssassinSteed.Actor;
using AssassinSteed.Actor.Enemy.BasicDuck;

namespace AssassinSteed.Scene.Testing.Eli.DuckTesting
{
    public class GameInit: MonoBehaviour
    {
        
        void Start()
        {

            CharacterMomento[] enemies = new CharacterMomento[]{
                new DuckMomento("Quackers",   100, Vector3.zero,  Vector3.zero),
                new DuckMomento("Corn Bread", 100, Vector3.one,  Vector3.zero)
            };

            new LevelMediatorBuilder("Testing")
                .WithCharacters(enemies, "Enemies")
                .Build();
        }

    }
}