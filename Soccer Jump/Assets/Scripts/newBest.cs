using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class newBest : MonoBehaviour {
	Text newestBest;
    Animator animator;
	private bool firstBest = true;
	private int counter = 0;

	void Start () {
		newestBest = GetComponent<Text>();
        firstBest = true;
        animator = GetComponent<Animator>();
	}

	void Update () {
        if(scoreScript.scoreValue > PlayerPrefs.GetInt("High Score") && firstBest == true) 
        {
            animator.SetTrigger("newBest");  
        }
	}

		
}
