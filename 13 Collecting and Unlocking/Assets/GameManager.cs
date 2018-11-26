using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager control;

	public bool pacmanUnlocked, mushroomUnlocked;
	public int heartCount;

	void Awake(){
		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this;
		} else if (control != this) {
			Destroy (gameObject);
		}
	}

	void Start(){
		pacmanUnlocked = true;
		mushroomUnlocked = false;
		heartCount = 0;
	}


}
