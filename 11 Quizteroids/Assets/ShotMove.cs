using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMove : MonoBehaviour {

	float shotSpeed;

	void Start(){
		shotSpeed = 20;
	}

	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * Time.deltaTime * shotSpeed);
		removeShots ();
	}

	void removeShots(){
		if (transform.position.x <= -14 || transform.position.x >= 14 || transform.position.z <= -11 || transform.position.z >= 11) {
			Destroy (this.gameObject);			
		}
	}
}
