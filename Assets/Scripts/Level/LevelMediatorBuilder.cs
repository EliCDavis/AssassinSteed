using System.Collections.Generic;
using UnityEngine;
using AssassinSteed.Actor;

namespace AssassinSteed.Level
{
    /// <summary>
    /// Meant for building a level mediator, and in turn the entire level. When
    /// no map is supplied, the mediator will assume to build everything in the
    /// current scene loaded.
    /// 
    /// Look into making this immutable. 
    ///     (Even though Unity doesn't have immutable namespace)
    /// </summary>
    public class LevelMediatorBuilder
    {

        private MapType map;
        private string name;
        private Dictionary<string, List<CharacterMomento>> npcs;

        /// <summary>
        /// Required variables go in the constructor to garuntee their always
        /// there when building.
        /// </summary>
        /// <param name="name"></param>
        public LevelMediatorBuilder(string name)
        {
            this.name = name;
            this.npcs = new Dictionary<string, List<CharacterMomento>>();
        }

        /// <summary>
        /// Builds the level with the parameters passed in previously
        /// </summary>
        /// <returns></returns>
        public LevelMediator Build()
        {
            return new LevelMediator(this.name, this.map, this.npcs);
        }

        /// <summary>
        /// Optional call to add characters to the level. Chain multiple 
        /// together to keep adding more enemies.
        /// </summary>
        /// <param name="characters"></param>
        /// <param name="faction">
        /// What team the characters are apart of. Leave blank for free for all
        /// </param>
        /// <returns>The builder for chainable calls</returns>
        public LevelMediatorBuilder WithCharacters(CharacterMomento[] characters, string faction)
        {
            if(characters != null || characters.Length == 0)
            {
                string sanitizedFaction = faction == null ? "" : faction;
                if (npcs.ContainsKey(sanitizedFaction))
                {
                    npcs[sanitizedFaction].AddRange(characters);
                } 
                else
                {
                    npcs.Add(sanitizedFaction, new List<CharacterMomento>(characters));
                }
            } 
            else
            {
                Debug.LogWarning("Attempting to add null/0 characters to the level. Ignoring.");
            }
            return this;
        }

        /// <summary>
        /// Set the map we want to load.
        /// </summary>
        /// <param name="map"></param>
        /// <returns></returns>
        public LevelMediatorBuilder WithMap(MapType map)
        {
            this.map = map;
            return this;
        }

    }
}