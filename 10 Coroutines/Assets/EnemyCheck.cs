using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCheck : MonoBehaviour {

	GameObject enemy;

	void Start () {
		enemy = GameObject.FindWithTag("enemy");	
	}
	
	void Update () {
		StartCoroutine ("CheckForEnemies");
	}

	IEnumerator CheckForEnemies(){
		if (Vector3.Distance (transform.position, enemy.transform.position) < 3f) {
			Debug.Log ("enemy is near!");
		} else {
			Debug.Log ("no enemies detected");
		}
		yield return new WaitForSeconds (0.1f);
	}
}
