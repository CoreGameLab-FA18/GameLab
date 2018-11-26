using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol : MonoBehaviour {

	public float speed;
	public Transform[] moveSpots;
	private int randomSpot;

	private float waitTime;
	public float startWaitTime;

	public GameObject player;
	public float distCheck;

	// Use this for initialization
	void Start () {
		waitTime = startWaitTime;
		randomSpot = Random.Range (0, moveSpots.Length);
	}
	
	// Update is called once per frame
	void Update () {

		if (Vector3.Distance (transform.position, player.transform.position) < distCheck) {
		
			transform.position = Vector3.MoveTowards (transform.position, player.transform.position, speed * Time.deltaTime);
		
		} else {

			transform.position = Vector3.MoveTowards (transform.position, moveSpots [randomSpot].position, speed * Time.deltaTime);

			if (Vector3.Distance (transform.position, moveSpots [randomSpot].position) < 0.2f) {
				if (waitTime <= 0) {
					randomSpot = Random.Range (0, moveSpots.Length);
					waitTime = startWaitTime;
				} else {
					waitTime -= Time.deltaTime;
				}
			}
		}

	}
}
