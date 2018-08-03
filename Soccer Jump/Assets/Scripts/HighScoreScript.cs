using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreScript : MonoBehaviour {

	public static int highScore = 0; 					// Holds the value of the high score
	Text highestScore;
	void Start () {
		highestScore = GetComponent<Text> ();
		highScore = PlayerPrefs.GetInt ("High Score"); // Retrives the persistent high score
	}
	

	void Update () {
        if (scoreScript.scoreValue > highScore)
        {      // Updates the high score after it is beat
            highScore = scoreScript.scoreValue;
            PlayerPrefs.SetInt("High Score", highScore);
            playGamesScript.AddScoreToLeaderboard(GPGSIds.leaderboard_global_leaderboard, scoreScript.scoreValue);
        }
	}
}
