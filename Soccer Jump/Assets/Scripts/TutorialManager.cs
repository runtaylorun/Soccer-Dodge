using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour {
    public int isDisabled;
    public Text tapTxt;
    public Text downTxt;
    public GameObject tapImg;
    public GameObject downImg;

	void Start () {
        isDisabled = PlayerPrefs.GetInt("isDisabledTut");
        Debug.Log(isDisabled);
        if(isDisabled == 0) 
        {
            Debug.Log("Tutorial Active");
        } else
        {
            tapTxt.enabled = false;
            downTxt.enabled = false;
            tapImg.SetActive(false);
            downImg.SetActive(false);
            Debug.Log("Tutorial Disabled");
        }
	}
	
}
