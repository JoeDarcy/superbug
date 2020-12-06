using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HankyMovementScript : MonoBehaviour
{
	// Get game objects
	public GameObject hanky;

	// Movement speed and rigidbody2D
	public float moveSpeed;
	private Rigidbody2D hankyRigidbody2D;

	// Vectors for user input and setting velocity
	private Vector2 moveInput;
	private Vector2 moveVelocity;

	// Get rigidbody2D at start
	private void Start() {
		hankyRigidbody2D = GetComponent<Rigidbody2D>();
	}

	// Calculate bullet movement speed and direction
	private void Update() {
		moveInput = new Vector3(0f, 1f);
		moveVelocity = moveInput * moveSpeed;		
	}

	// Apply movement to the bullet
	private void FixedUpdate() {
		hankyRigidbody2D.velocity = moveVelocity;
	}
}
