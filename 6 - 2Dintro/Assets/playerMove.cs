using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public float val;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			GetComponent<Rigidbody2D> ().AddForce(Vector3.up * val, ForceMode2D.Impulse);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			GetComponent<Rigidbody2D> ().AddForce(Vector3.right * val, ForceMode2D.Impulse);
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			GetComponent<Rigidbody2D> ().AddForce(Vector3.left * val, ForceMode2D.Impulse);
		}
		
	}
}
