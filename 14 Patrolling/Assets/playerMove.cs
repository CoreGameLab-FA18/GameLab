using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

	int speed = 5;

	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {

		float vert = Input.GetAxis ("Vertical")*speed;
		float horz = Input.GetAxis ("Horizontal")*speed;

		vert *= Time.deltaTime;
		horz *= Time.deltaTime;

		transform.Translate(horz, vert, 0);
		
	}
}
