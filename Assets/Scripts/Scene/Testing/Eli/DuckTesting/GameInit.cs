using UnityEngine;
using AssassinSteed.Level;

namespace AssassinSteed.Scene.Testing.Eli.DuckTesting
{
    public class GameInit: MonoBehaviour
    {
        
        void Start()
        {
            Debug.Log("I work");
            new LevelMediatorBuilder("Testing")
                .WithCharacters(null, "Enemies")
                .WithCharacters(null, "Allies")
                .Build();
        }

    }
}