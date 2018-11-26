using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLevelObjects : MonoBehaviour {

	public GameObject mushroomGate;
	public GameObject heart1, heart2, heart3;

	void Start() {
		mushroomGate.SetActive (GameManager.control.mushroomUnlocked);
	}

}
