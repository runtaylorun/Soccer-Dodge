using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuManager : MonoBehaviour {

    public LevelChanger levelChangingScript;
    public AudioSource btnPress;

	public void toGame() {
        PlayerPrefs.Save();
        levelChangingScript.FadeToLevel(1);
	}
}
