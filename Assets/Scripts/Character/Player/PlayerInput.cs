using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AssassinSteed.Character.Player.PlayerInput
{

    /// <summary>
    /// Controls any kind of movement/actions taken in the scene
    /// </summary>
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerInput : Controller, IGroundMovementControl
    {

        /// <summary>
        /// Reference to the rigidbody object that takes care of movement in 
        /// the scene
        /// </summary>
        
        public float maxXRotation;
        public float maxYRotation;

        private Rigidbody rigidbody;

        

        void Start()
        {
            this.rigidbody = gameObject.GetComponentInChildren<Rigidbody>();
            this.speed = 5f;
        }

        public void MoveForward(float degree)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * this.speed * Mathf.Clamp(degree, 0f, 1f));
        }

        public void MoveBackward(float degree)
        {
            transform.Translate(Vector3.back * Time.deltaTime * this.speed * Mathf.Clamp(degree, 0f, 1f));
        }

        public void MoveRight(float degree)
        {
            transform.Translate(Vector3.right * Time.deltaTime * this.speed * Mathf.Clamp(degree, 0f, 1f));
        }

        public void MoveLeft(float degree)
        {
            transform.Translate(Vector3.left * Time.deltaTime * this.speed * Mathf.Clamp(degree, 0f, 1f));
        }

        public void Rotate(float degree)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * Mathf.Clamp(degree, -180, 180), Space.World);
        }

        public void ApplyMovment()
        {
            float _horizontal = Input.GetAxis("Horizontal");
            float _vertical = Input.GetAxis("Vertical");
            Vector3 _movment = new Vector3(_horizontal, 0.0f, _vertical);

            rigidbody.velocity = _movment * this.speed;
        }

        public void ApplyRotation()
        {

        }

        private void FixedUpdate()
        {
            ApplyMovment();
        }

    }

}
