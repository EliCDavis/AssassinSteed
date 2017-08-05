using AssassinSteed.Actor;
using System.Collections.Generic;

namespace AssassinSteed.Level
{

    /// <summary>
    /// Meant for keeping up with everything going on in a single level, such
    /// as what enemies are alive and where the player is.
    /// 
    /// https://sourcemaking.com/design_patterns/mediator
    /// </summary>
    public class LevelMediator
    {
        
        private List<Character> characters;

        /// <summary>
        /// Protected to encourage the use of the builder.
        /// </summary>
        protected LevelMediator(Character[] characters)
        {
            this.characters = new List<Character>(characters);
        }

    }
}