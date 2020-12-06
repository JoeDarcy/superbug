using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmMovementScript : MonoBehaviour
{
	// Get game objects
	public GameObject phoneArm;

	// Movement speed and rigidbody2D
	public float moveSpeed;
	private Rigidbody2D phoneArmRigidbody2D;

	// Vectors for user input and setting velocity
	private Vector2 moveInput;
	private Vector2 moveVelocity;

	// Get rigidbody2D at start
	private void Start() {
		phoneArmRigidbody2D = GetComponent<Rigidbody2D>();
	}

	// Calculate bullet movement speed and direction
	private void Update() {
		moveInput = new Vector3(-1f, 0f);
		moveVelocity = moveInput * moveSpeed;
	}

	// Apply movement to the bullet
	private void FixedUpdate() {
		phoneArmRigidbody2D.velocity = moveVelocity;
	}
}
