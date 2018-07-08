using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AspectRatio : MonoBehaviour {

	float originalWidth = 1920f;
	float originalHeight = 1080f;
	void Start () {
		gameObject.GetComponent<Camera>().aspect = (originalWidth / originalHeight) * (Screen.width / Screen.height);
	}
}
