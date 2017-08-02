using UnityEngine;

namespace AssassinSteed.Character
{
    public abstract class Character : MonoBehaviour
    {
        
        private int MAX_HEALTH;

        private int currentHealth;

        private int getCurrentHealth(){
            return this.currentHealth;
        }

    }
}