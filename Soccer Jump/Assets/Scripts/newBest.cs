using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class newBest : MonoBehaviour {
	Text newestBest;
	private bool firstBest = true;
	private int counter = 0;

	void Start () {
		newestBest = GetComponent<Text>();
		newestBest.gameObject.SetActive (false);
	}

	void Update () {
		Debug.Log (counter);
		if(scoreScript.scoreValue > HighScoreScript.highScore && firstBest == true) {
			newestBest.gameObject.SetActive (true);
			StartCoroutine ("startBlinking");
		}
	}

	IEnumerator startBlinking() {
		newestBest.text = "";
		yield return new WaitForSeconds (1);
		newestBest.text = "New Best";
		yield return new WaitForSeconds (1);
		newestBest.text = "";
		yield return new WaitForSeconds (1);
		newestBest.text = "New Best";
		yield return new WaitForSeconds (1);
		newestBest.text = "";
		yield return new WaitForSeconds (1);
		newestBest.text = "New Best";
		yield return new WaitForSeconds (1);
		newestBest.text = "";
		newestBest.gameObject.SetActive (false);
		firstBest = false;

	}
		
}
