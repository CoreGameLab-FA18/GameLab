using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPacmanLevel : MonoBehaviour {

	public GameObject key, enemy;
	// Use this for initialization
	void Start () {
		
		if (GameManager.control.heartCount == 3) {
			enemy.SetActive (false);
		} else {
			key.SetActive (false);
		}
		
	}

}
