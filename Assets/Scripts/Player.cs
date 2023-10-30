using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public float speed = 5f;
	public float force = 5f;

	public int store = 0;

	public Rigidbody2D rb;
	public Vector2 direction;
	public GroundDetection groundDetection;
	private void FixedUpdate()
	{
		direction = Vector3.zero;

		if (Input.GetKey(KeyCode.A))
		{
			direction = Vector3.left;
		}
		if (Input.GetKey(KeyCode.D))
		{
			direction = Vector3.right;
		}
		direction *= speed;
		direction.y = rb.velocity.y;
		rb.velocity = direction;
		if (Input.GetKeyDown(KeyCode.Space) && groundDetection.isGrounded)
		{
			rb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
		}
	}
}
