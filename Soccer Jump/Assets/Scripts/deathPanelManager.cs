﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class deathPanelManager : MonoBehaviour {

	public GameObject soccerBall;
    public Text endScore;
    public Text currentCoins;
    public Text coinsAdded;
	private moveBall moveBallScript;
	private bool tempPlayerDead;
	public GameObject panel;
    public LevelChanger levelChangingScript1;
	void Start () {
		panel.SetActive (false);
	}


	void Update () {
		moveBallScript = soccerBall.GetComponent<moveBall> ();
		tempPlayerDead = moveBall.playerDead;
		if (tempPlayerDead == true) { 		// If the playr is dead, show the death panel	
			panel.SetActive (true);
            endScore.text = "Current Score " + scoreScript.scoreValue;
            currentCoins.text = "Coins ";
            coinsAdded.text = "Coins Added ";
		}
	}

	public void toGame() {					// Function to load the game
        levelChangingScript1.FadeToLevel(1);
	}

	public void toMenu() {					// Function to go to the main menu
        levelChangingScript1.FadeToLevel(0);
	}
		
}
