using AssassinSteed.Actor;
using System.Collections.Generic;

namespace AssassinSteed.Level
{

    /// <summary>
    /// Meant for keeping up with everything going on in a single level, such
    /// as what enemies are alive and where the player is.
    /// 
    /// Without any map specified the characters will be built in the current
    /// scene. 
    /// 
    /// https://sourcemaking.com/design_patterns/mediator
    /// </summary>
    public class LevelMediator
    {
        
        Dictionary<string, List<Character>> characters;

        public LevelMediator(string name, MapType map, Dictionary<string, List<CharacterMomento>> npcs)
        {
            // Load map
            if(map != MapType.None)
            {

            }

            // Build characters
            characters = new Dictionary<string, List<Character>>();
            if(npcs != null)
            {
                foreach (KeyValuePair<string, List<CharacterMomento>> pair in npcs)
                {
                    List<Character> charactersInFaction = 
                        new List<Character>();
                    
                    foreach (CharacterMomento momento in pair.Value)
                    {
                        charactersInFaction.Add(momento.BuildCharacter(this));
                    }

                    this.characters.Add(pair.Key, charactersInFaction);
                }
            }
        }

    }
}