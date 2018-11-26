using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	float moveForce;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		moveForce = 20;
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			rb.AddTorque (-Vector3.up, ForceMode.Impulse);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			rb.AddTorque (Vector3.up, ForceMode.Impulse);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			rb.AddForce (transform.forward * moveForce, ForceMode.Acceleration);
		}
		resetPos ();		
	}

	void resetPos(){
		if (transform.position.x <= -17) {
			transform.position = new Vector3(16, transform.position.y, transform.position.z);
		}
		if (transform.position.x >= 17) {
			transform.position = new Vector3(-16, transform.position.y, transform.position.z);
		}
		if (transform.position.z <= -11) {
			transform.position = new Vector3(transform.position.x, transform.position.y, 10);
		}
		if (transform.position.z >= 11) {
			transform.position = new Vector3(transform.position.x, transform.position.y, -10);
		}
	}
}
