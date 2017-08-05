using UnityEngine;

namespace AssassinSteed.Actor.Enemy.BasicDuck
{

    enum DuckState {
        Patroll,
        Persuit
    }

    /// <summary>
    /// The AI for the duck. Takes care of utilizing the controller to move 
    /// around and attack things and well, be a fucking duck
    /// </summary>
    [RequireComponent(typeof(DuckController))]
    public class DuckAICharacter: AICharacter
    {
        
        /// <summary>
        /// Reference to the controller that takes care of actuall movement 
        /// within the scene. We tell the controller what we want the duck
        /// to do.
        /// </summary>
        private DuckController controller;

        /// <summary>
        /// The current state the duck is operating under, dictates what it's 
        /// trying to do in the scene.
        /// </summary>
        private DuckState currentState;

        /// <summary>
        /// Value [0, 1] that dictates what percentage of the ducks speed we
        /// want to move at while it's patrolling
        /// </summary>
        private float patrollSpeed;

        /// <summary>
        /// Called once when the scene is initialized
        /// </summary>
        void Start()
        {
            this.controller = gameObject.GetComponent<DuckController>();
            this.currentState = DuckState.Patroll;
            this.patrollSpeed = 0.7f;
        }

        /// <summary>
        /// Called once per frame by the Unity Engine
        /// </summary>
        void Update()
        {
            switch (this.currentState) {
                case DuckState.Patroll:
                    PatrolUpdate();
                    break;

                case DuckState.Persuit:
                    PersuitUpdate();
                    break;
            }
        }

        /// <summary>
        /// Takes care of performing all actions appropriate when switching
        /// from one state to another.
        /// 
        /// TODO: Find design pattern for taking care of states/state machines
        /// </summary>
        private void SwitchState(DuckState newState)
        {
            this.currentState = newState;
        }

        /// <summary>
        /// Called once per frame when the duck is currently looking for 
        /// something to do.
        /// </summary>
        private void PatrolUpdate()
        {
            // Walk in a circle
            this.controller.MoveForward(this.patrollSpeed);
            this.controller.Rotate(30);

            // See if we can see anybody
            if(this.visibleCharacters() != null)
            {
                this.SwitchState(DuckState.Persuit);
            }
        }

        /// <summary>
        /// Called once per frame when the duck is currently chasing a target.
        /// </summary>
        private void PersuitUpdate()
        {
            Character[] characters = this.visibleCharacters();

            // Can't persue if theres no body around
            if(characters == null || characters.Length == 0)
            {
                this.SwitchState(DuckState.Patroll);
                return;
            }

            // TODO : insert chasing mechanisms            

        }

    }
}