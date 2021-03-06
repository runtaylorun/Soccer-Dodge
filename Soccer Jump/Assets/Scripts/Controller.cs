﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	public float jumpForce;
	public static bool canJump = true;
	public static bool canCrouch = true;
    public static bool didTouch = false;
    public AudioSource jump;

	private Rigidbody2D playerRigidBody;
	private BoxCollider2D playerCollider;

	void Start () {
		playerRigidBody = GetComponent<Rigidbody2D> ();
		playerCollider = GetComponent<BoxCollider2D> ();
	}
		

	void Update () {
		if (Input.touchCount > 0 && moveBall.playerDead == false) {
            didTouch = true;
			var touch = Input.GetTouch (0);
			if (touch.position.x < Screen.width / 2 && canJump == true) {
				playerRigidBody.velocity = new Vector2 (playerRigidBody.velocity.x, jumpForce);
                jump.Play();
			} else if (touch.position.x > Screen.width / 2 && canCrouch == true && touch.phase != TouchPhase.Ended) {
				PlayerCollision.anim.SetBool ("isCrouching", true);
			} else {
				PlayerCollision.anim.SetBool ("isCrouching", false);
			}
		}
	}
}