using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adjustValues : MonoBehaviour {

	// Use this for initialization
	void OnGUI () {
		// make 4 buttons that change values in gameControl
		// gameControl = name of script
		// control = static variable
		// variable = which variable you want to change

		if (GUI.Button (new Rect (10, 100, 100, 30), "Health up")) {
			gameControl.control.health += 10;
		}
		if (GUI.Button (new Rect (10, 140, 100, 30), "Health down")) {
			gameControl.control.health -= 10;
		}
		if (GUI.Button (new Rect (10, 180, 100, 30), "Experience up")) {
			gameControl.control.experience += 10;
		}
		if (GUI.Button (new Rect (10, 220, 100, 30), "Experience up")) {
			gameControl.control.experience -= 10;
		}

		if (GUI.Button (new Rect (10, 260, 100, 30), "Save")) {
			gameControl.control.Save();
		}
		if (GUI.Button (new Rect (10, 300, 100, 30), "Load")) {
			gameControl.control.Load();
		}
	}

}
