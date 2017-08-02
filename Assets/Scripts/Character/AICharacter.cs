namespace AssassinSteed.Character
{
    public class AICharacter : Character
    {
        
        /// <summary>
        /// Angle at which how far of an angle a character can see
        /// </summary>
        private float fov;

        /// <summary>
        /// how far out a character can see
        /// </summary>
        private float lineOfSite;

        /// <summary>
        /// All visible characters are determined by orientation of the character, fov, and line of site
        /// </summary>
        /// <returns>All characters visible</returns>
        protected Character[] visibleCharacters() {
            return null;
        }

    }
}