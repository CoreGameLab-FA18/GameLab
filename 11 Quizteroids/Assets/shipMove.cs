using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipMove : MonoBehaviour {

	float moveForce;
	float turnSpeed;
	Rigidbody rb;
	public GameObject manager;

	// Use this for initialization
	void Start () {
		moveForce = 20;
		turnSpeed = 10;
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.eulerAngles = new Vector3 (0, transform.eulerAngles.y - turnSpeed, 0);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.eulerAngles = new Vector3 (0, transform.eulerAngles.y + turnSpeed, 0);
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
		if (Time.time > 3) {
			if (other.gameObject.tag == "asteroid") {
				manager.GetComponent<makeAsteroids> ().Lose ();	
			}
		}
	}
		
}
