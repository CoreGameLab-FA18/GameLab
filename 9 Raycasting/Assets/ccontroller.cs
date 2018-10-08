using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ccontroller : MonoBehaviour {

	Rigidbody rb;
	Camera viewCamera;

	public float moveSpeed = 6;
	Vector3 velocity;

	void Start () {
		rb = GetComponent<Rigidbody> ();
		viewCamera = Camera.main;
	}
	
	void Update () {
		// find normalized "world point" mousepos on screen 
		Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));
		// make character rotate to look at mousepos, but don't look up
		transform.LookAt(mousePos + Vector3.up * transform.position.y);
		// make move based on arrow keys
		velocity = new Vector3 (Input.GetAxisRaw("Horizontal"),0, Input.GetAxisRaw("Vertical")).normalized * moveSpeed;
	}

	void FixedUpdate(){
		// apply rb movement
		rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
	}
}
