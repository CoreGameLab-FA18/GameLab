using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCollected : MonoBehaviour {

	public Image pacman_icon, mushroom_icon, heart1, heart2, heart3;
	
	void Start(){
		heart1.enabled = false;
		heart2.enabled = false;
		heart3.enabled = false;
	}

	void Update () {
	
		pacman_icon.enabled = GameManager.control.pacmanUnlocked;
		mushroom_icon.enabled = GameManager.control.mushroomUnlocked;

		if (GameManager.control.heartCount >= 1) {
			heart1.enabled = true;
		}
		if (GameManager.control.heartCount >= 2) {
			heart2.enabled = true;
		}
		if (GameManager.control.heartCount >= 3) {
			heart3.enabled = true;
		}

	}
}
