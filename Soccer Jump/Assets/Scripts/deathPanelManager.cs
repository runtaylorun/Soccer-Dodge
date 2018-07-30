using System.Collections;
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
    public AudioSource btnTap;
	void Start () {
		panel.SetActive (false);
	}


	void Update () {
		moveBallScript = soccerBall.GetComponent<moveBall> ();
		tempPlayerDead = moveBall.playerDead;
		if (tempPlayerDead == true) { 		// If the playr is dead, show the death panel	
			panel.SetActive (true);
            endScore.text = scoreScript.scoreValue.ToString();
            currentCoins.text = "Coins ";
            coinsAdded.text = "Coins Added ";
		}
	}

	public void toGame() {
        btnTap.Play();
        levelChangingScript1.FadeToLevel(1);
	}

	public void toMenu() {
        btnTap.Play();
        levelChangingScript1.FadeToLevel(0);
	}
		
}
