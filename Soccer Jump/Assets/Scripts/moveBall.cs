using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class moveBall : MonoBehaviour {

	public float ballSpeed;
	public float ballHeight;
    public static bool playerDead;
    public int upOrDown;
    private bool neverDone = true;
    public AudioSource kick;
    public AudioSource dead;

	public static Animator anim;
	private Transform trans;
	private Rigidbody2D ballRigidBody;



	void Start () {
		anim = GetComponent<Animator> ();
		playerDead = false;
		ballRigidBody = GetComponent<Rigidbody2D> ();
		trans = GetComponent<Transform> ();
		scoreScript.scoreValue = 0;
	}

	


	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Kicker 2") {
			kicker2Anim.anim.SetTrigger ("Det2");
            kick.Play();
			ballSpeed = -18;
			upOrDown = Random.Range (1, 3);
			scoreScript.scoreValue += 1;
			if (upOrDown == 1) {
				goBall ();
			} else {
				goBallUp ();
			}
		}
		if (col.gameObject.tag == "Kicker 1") {
			kicker1Anim.anim.SetTrigger ("Det1");
            kick.Play();
			ballSpeed = 18;
			upOrDown = Random.Range (1, 3);
			scoreScript.scoreValue += 1;
			if (upOrDown == 1) {
				goBall ();
			} else {
				goBallUp ();
			}
		}
		if (col.gameObject.tag == "Player") {
			playerDead = true;
			Controller.canCrouch = false;
			PlayerCollision.anim.SetBool ("inAir", false);
			PlayerCollision.anim.SetBool ("isCrouching", false);
			PlayerCollision.anim.SetBool ("isDead", true);
			anim.SetBool ("isDead", true);
            dead.Play();
			ballSpeed = 0;
			ballRigidBody.velocity = Vector2.zero;
			ballRigidBody.constraints = RigidbodyConstraints2D.FreezeAll;
            Controller.didTouch = false;
            neverDone = true;
            CountDown.neverDone = true;
		}
	}
	IEnumerator DelayStart() {
		yield return new WaitForSeconds (3);
		goBall ();
	}



    void Update () {
        if (Controller.didTouch == true && neverDone == true)
        {
            StartCoroutine("DelayStart");
            neverDone = false;
        }
		if (ballRigidBody.velocity.x > 0) {
			trans.Rotate (Vector3.forward * -10);
		} else if (ballRigidBody.velocity.x < 0) {
			trans.Rotate (Vector3.forward * 10);
		}
	}

	 void goBall() {
		ballRigidBody.velocity = new Vector2 (ballSpeed, ballRigidBody.velocity.y);
	}

	void goBallUp() {
		ballRigidBody.velocity = new Vector2 (ballSpeed, ballHeight);
	}
}

