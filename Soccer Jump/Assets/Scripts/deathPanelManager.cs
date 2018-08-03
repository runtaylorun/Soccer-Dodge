using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class deathPanelManager : MonoBehaviour {

	public GameObject soccerBall;
    public Text endScore;
    public Text currentCoins;
    public Text coinsAdded;
    public Text highestScore;
    public Text scoreTxt;
	private moveBall moveBallScript;
	private bool tempPlayerDead;
	public GameObject panel;
    public LevelChanger levelChangingScript1;
    public AudioSource btnTap;
    public Animator animator;
	void Start () {
        animator.SetBool("isDead", false);
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
            highestScore.text = HighScoreScript.highScore.ToString();
            animator.SetBool("isDead", true);
            scoreTxt.enabled = false;
		}
	}

	public void toGame() {
        levelChangingScript1.FadeToLevel(1);
        PlayerPrefs.Save();
	}

	public void toMenu() {
        levelChangingScript1.FadeToLevel(0);
        PlayerPrefs.Save();
	}
		
}
