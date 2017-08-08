using UnityEngine;
using AssassinSteed.Level;

namespace AssassinSteed.Actor.Enemy.BasicDuck
{
    public class DuckMomento : CharacterMomento
    {
        
        public DuckMomento(
            string name,
            int health,
            Vector3 position,
            Vector3 rotation
            ): base(name, health, position, rotation)
        {

        }

        public override Character BuildCharacter(LevelMediator mediator)
        {
            GameObject instance = GameObject.Instantiate(Resources.Load<GameObject>("Characters/Duck"), position, Quaternion.identity);
            return instance.GetComponent<DuckAICharacter>();
        }

    }
}