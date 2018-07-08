using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountDown : MonoBehaviour {
	public Text cntDown;


	void Start() {
		cntDown = GetComponent<Text>();
		StartCoroutine ("getReady");
	}
	void Update() {
		
	}
	IEnumerator getReady () { // Function for counting down at the beginning

		cntDown.text = "3";
		yield return new WaitForSeconds (1);

		cntDown.text = "2";
		yield return new WaitForSeconds (1);

		cntDown.text = "1";
		yield return new WaitForSeconds (1);

		cntDown.text = "GO";
		yield return new WaitForSeconds (1);

		cntDown.text = "";


	}


}
