using UnityEngine;
using AssassinSteed.Level;

namespace AssassinSteed.Actor
{

    /// <summary>
    /// Meant for encasulating everything about a character so that we can
    /// restore it's state exactly how it was at some point in time.
    /// 
    /// https://sourcemaking.com/design_patterns/memento
    /// 
    /// (Should probably be command/builder)
    /// </summary>
    public abstract class CharacterMomento
    {

        /// <summary>
        /// Health that the character starts out with.
        /// </summary>
        protected int currentHealth;

        /// <summary>
        /// Name of the character
        /// </summary>
        protected string name;

        /// <summary>
        /// Position of the character in the scene
        /// </summary>
        protected Vector3 position;

        /// <summary>
        /// Rotation of the chracter in the scene
        /// </summary>
        protected Vector3 rotation;

        public CharacterMomento(string name, int health, Vector3 position, Vector3 rotation)
        {
            this.position = position;
            this.rotation = rotation;
            this.name = name;
            this.currentHealth = health;
        }

        /// <summary>
        /// Given the current state of the momento, build a character from
        /// it.
        /// 
        /// Kinda makes this more of a builder or something..
        /// </summary>
        /// <returns></returns>
        public abstract Character BuildCharacter(LevelMediator mediator);

    }
}