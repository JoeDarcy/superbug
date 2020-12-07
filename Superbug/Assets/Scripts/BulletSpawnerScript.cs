using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawnerScript : MonoBehaviour {

	// Get game object 
	public GameObject bulletSpawner;

	// Setting public float for movement speed and getting rigidbody2D
	public float moveSpeed;
	private Rigidbody2D bulletSpawnerRigidbody2D;

	// Vectors for user input and setting velocity
	private Vector2 moveInput;
	private Vector2 moveVelocity;

	// Setting spawner movement speed and initialising spawner timer
	public float spawnerMovementSpeed = 5;
	private float spawnerTimer = 0.0f;
	private float moveTimer = 0.0f;
	private float cooldownTimer = 0.0f;

	// Getting rigidbody2D component
	private void Start() {
		bulletSpawnerRigidbody2D = GetComponent<Rigidbody2D>();
	}

	// Calculate inputs and velocity
	private void Update() {
		/*
		moveInput = new Vector2(0f, -0.5f);
		moveVelocity = moveInput * moveSpeed;

		// Not needed? Test
		moveInput = new Vector2(0f, 0.5f);
		moveVelocity = moveInput * moveSpeed;
		*/

		moveTimer += Time.deltaTime;

	
		if (moveTimer < 2.5) {
			moveInput = new Vector2(-0.2f, -0.5f);
			moveVelocity = moveInput * moveSpeed;
		} else if (moveTimer < 5) {
			moveInput = new Vector2(-0.2f, 0.5f);
			moveVelocity = moveInput * moveSpeed;
		} else {
			moveTimer = 0;
		}

		
		// Block player movement too far into screen and add push against blood flow
		if (transform.position.x > -6 && transform.position.x < -3) {
			moveInput = new Vector2(-2f, 0.5f);
			moveVelocity = moveInput * moveSpeed;
		}		
		if (transform.position.x > -3 && transform.position.x < 0) {
			moveInput = new Vector2(-4f, 0.5f);
			moveVelocity = moveInput * moveSpeed;
		}
		
		if (transform.position.x > 0 && transform.position.x < 3) {
			moveInput = new Vector2(-6f, 0.5f);
			moveVelocity = moveInput * moveSpeed;
		}
		
	}

	// Set bullet velocity and trigger firing with spacebar
	private void FixedUpdate() {

		bulletSpawnerRigidbody2D.velocity = moveVelocity;

		spawnerTimer += Time.deltaTime;
		cooldownTimer += Time.deltaTime;

		// Fire while holding spacebar but cooldown timer in effect
		if (Input.GetKey("space") && cooldownTimer > 0.75) {
			Instantiate(bulletSpawner, transform.position, Quaternion.identity);
			cooldownTimer = 0;
			spawnerTimer = 0;
		}

		// Mouse button controls
		if (Input.GetMouseButtonDown(0) && cooldownTimer > 0.75) {
			Instantiate(bulletSpawner, transform.position, Quaternion.identity);
			cooldownTimer = 0;
			spawnerTimer = 0;
		}

		// Experimental feature: Fire when space is pressed but with slight cooldown timer
		if (Input.GetKeyDown("space") && cooldownTimer > 0.5) {
			Instantiate(bulletSpawner, transform.position, Quaternion.identity);					
		}
		
	}
}
