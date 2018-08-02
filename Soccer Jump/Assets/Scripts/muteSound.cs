using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muteSound : MonoBehaviour {
    public int isMuted;
	void Start () {
        isMuted = PlayerPrefs.GetInt("isMuted");
        Debug.Log(isMuted);
        if(isMuted == 0)
        {
            AudioListener.volume = 1f;
        } else {
            AudioListener.volume = 0f;
        }

	}
	
	
	void Update () {
	}
}
