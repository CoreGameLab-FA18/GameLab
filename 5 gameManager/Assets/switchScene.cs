using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchScene : MonoBehaviour {

	public int sceneToLoad;

	void OnGUI(){
		if (GUI.Button (new Rect (Screen.width / 2 - 50, Screen.height - 50, 100, 40), "Load Scene: " + (sceneToLoad + 1))) {
			SceneManager.LoadScene (sceneToLoad);
		}
	}
}
