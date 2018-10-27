using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

	public GameObject pewpew;
	public Transform shotLoc;
	bool doShoot;
	float shotTimer;

	// Use this for initialization
	void Start () {
		doShoot = true;
		shotTimer = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (doShoot) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				Instantiate (pewpew, shotLoc.position, shotLoc.rotation);
				doShoot = false;
			}
		} else {
			shotTimer += Time.deltaTime;
			if (shotTimer > .2f) {
				doShoot = true;
				shotTimer = 0;
			}
		}
	}
}
