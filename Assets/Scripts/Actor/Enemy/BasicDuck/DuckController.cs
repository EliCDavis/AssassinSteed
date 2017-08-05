using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AssassinSteed.Actor.Enemy.BasicDuck
{

	/// <summary>
	/// Controls any kind of movement/actions taken in the scene
	/// </summary>
	[RequireComponent(typeof(Rigidbody))]
	public class DuckController : Controller, IGroundMovementControl
	{

		/// <summary>
		/// Reference to the rigidbody object that takes care of movement in 
		/// the scene
		/// </summary>
		private Rigidbody rigidbody;

		void Start()
		{
			this.rigidbody = gameObject.GetComponent<Rigidbody>();
			this.speed = 3f;
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

	}

}