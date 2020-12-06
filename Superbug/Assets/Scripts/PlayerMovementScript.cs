using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{	
	// Getting player movement speed and rigidbody2D
    public float moveSpeed;

	/*
    private Rigidbody2D playerRigidbody2D;

	// Gets player input and velocity
	private Vector2 moveInput;
	private Vector2 moveVelocity;

	// Getting the rigidbody2D component
	private void Start() {
		playerRigidbody2D = GetComponent<Rigidbody2D>();
	}
	

	// Gets player inputs and calculates velocity
	private void Update() {
		moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		moveVelocity = moveInput * moveSpeed;
	}
	*/

	// Applies velocity to the players rigidbody2D
	private void FixedUpdate() {
		//playerRigidbody2D.velocity = moveVelocity;

		playerMovement();
	}

	private void playerMovement() {

		float moveX = 0f;
		float moveY = 0f;

		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
			moveY = +1f;
		}
		if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
			moveY = -1f;
		}
		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
			moveX = -1f;
		}
		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
			moveX = +1f;
		}

		Vector3 moveDirection = new Vector3(moveX, moveY).normalized;

		transform.position += moveDirection * moveSpeed * Time.deltaTime;
	}

}
