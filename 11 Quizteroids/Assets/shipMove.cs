using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipMove : MonoBehaviour {

	float moveForce;
	Rigidbody rb;
	public GameObject manager;
	float time;

	// Use this for initialization
	void Start () {
		moveForce = 20;
		rb = GetComponent<Rigidbody>();
		time = Time.time;
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
		if (transform.position.x <= -14) {
			transform.position = new Vector3(13, transform.position.y, transform.position.z);
		}
		if (transform.position.x >= 14) {
			transform.position = new Vector3(-13, transform.position.y, transform.position.z);
		}
		if (transform.position.z <= -11) {
			transform.position = new Vector3(transform.position.x, transform.position.y, 10);
		}
		if (transform.position.z >= 11) {
			transform.position = new Vector3(transform.position.x, transform.position.y, -10);
		}
	}

	void OnTriggerEnter(Collider other){
		if (Time.time - time > 3) {
			if (other.gameObject.tag == "asteroid") {
				manager.GetComponent<makeAsteroids> ().Lose ();	
			}
		}
	}
		
}
