using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerCollision : MonoBehaviour {

	public static Animator anim;

	void Start() {
		anim = GetComponent<Animator> ();
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Air") {
			Controller.canJump = false;
			Controller.canCrouch = false;
			anim.SetBool ("inAir", true);
	}
}
	void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.tag == "Ground") {
			Controller.canJump = true;
			Controller.canCrouch = true;
			anim.SetBool ("inAir", false);
		}
	}
}
