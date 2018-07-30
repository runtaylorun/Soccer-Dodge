using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountDown : MonoBehaviour {
	public Text cntDown;
    public GameObject tapDwn;
    public GameObject holdDwn;
    public Text tapTxt;
    public Text holdTxt;
    public static bool neverDone = true;
    public AudioSource countDown;
    public AudioSource go;


	void Start() {
		cntDown = GetComponent<Text>();
        cntDown.text = "";
	}

	private void Update()
	{
        if (Controller.didTouch == true && neverDone == true)
        {
            StartCoroutine("getReady");
            neverDone = false;
        }
	}

	IEnumerator getReady () { // Function for counting down at the beginning

		cntDown.text = "3";
        countDown.Play();
		yield return new WaitForSeconds (1);

		cntDown.text = "2";
        countDown.Play();
		yield return new WaitForSeconds (1);

		cntDown.text = "1";
        countDown.Play();
		yield return new WaitForSeconds (1);

		cntDown.text = "GO";
        go.Play();
		yield return new WaitForSeconds (1);

		cntDown.text = "";
        tapDwn.SetActive(false);
        holdDwn.SetActive(false);
        tapTxt.text = "";
        holdTxt.text = "";


	}


}
