using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class makeAsteroids : MonoBehaviour {

	public Transform asteroid;
	GameObject player;
	public Text loseText;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Ship");
		for (int i = 0; i < 5; i++) {
			Instantiate(asteroid, new Vector3(0, 0, 0), Quaternion.identity);
		}
		
	}
	
	// Update is called once per frame
	public void Lose () {
		Destroy (player);
		loseText.text = "GAME OVER";
	}
}
