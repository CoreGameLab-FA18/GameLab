using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereGame : MonoBehaviour {

	public float moveforce;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
//		moveforce = 100f;
		rb = GetComponent <Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	void FixedUpdate(){
		if (Input.GetKeyDown(KeyCode.W)) {
			rb.AddForce(Vector3.up * moveforce*2, ForceMode.Impulse);
		}

		if (Input.GetKeyDown(KeyCode.A)) {
			rb.AddForce(Vector3.back * moveforce, ForceMode.Impulse);
		}

		if (Input.GetKeyDown(KeyCode.D)) {
			rb.AddForce(Vector3.forward * moveforce, ForceMode.Impulse);
		}
	}

}
