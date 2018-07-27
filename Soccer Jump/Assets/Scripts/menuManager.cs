using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuManager : MonoBehaviour {

    public LevelChanger levelChangingScript;
	public void toGame() {					// Function that load the game level
        levelChangingScript.FadeToLevel(1);
	}
}
