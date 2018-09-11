using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physics : MonoBehaviour {

	public float upforce;

	// Use this for initialization
	void Start () {
		upforce = 10f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision other){
//		Debug.Log (other.gameObject.tag);
		if (other.gameObject.tag == "sphere") {
			GetComponent<Renderer> ().material.color = Color.red;
		}
	}

	void OnCollisionStay (Collision other){
	}

	void OnCollisionExit (Collision other){
		if (other.gameObject.tag == "sphere") {
			GetComponent<Renderer> ().material.color = Color.blue;
		}
	}

	void OnMouseDown(){
		GetComponent<Rigidbody> ().AddForce(Vector3.up * upforce);
	}

	void OnTriggerStay(Collider other){
//		Debug.Log ("triggered");
		GetComponent<Rigidbody> ().AddForce(Vector3.up * upforce);
		GetComponent<Rigidbody> ().AddTorque (transform.right * 10);
	}
}
