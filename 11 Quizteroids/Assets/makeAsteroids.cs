using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class makeAsteroids : MonoBehaviour {

	public Transform asteroid;
	GameObject player;
	public GameObject canvas;
	bool gameOver;

	// Use this for initialization
	void Start () {
		gameOver = false;
		canvas.SetActive (false);
		player = GameObject.Find ("Ship");
		for (int i = 0; i < 5; i++) {
			Instantiate(asteroid, new Vector3(0, 0, 0), Quaternion.identity);
		}
	}

	void Update(){
		if (gameOver) {
			if (Input.GetKeyDown (KeyCode.R)) {
				SceneManager.LoadScene ("Start");
			}
		}
	}

	public void Lose () {
		Destroy (player);
		canvas.SetActive (true);
		gameOver = true;
	}
}
