using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookingDown : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	public float height = 10;
	void Update(){

		RaycastHit hit;
		Ray lookDown = new Ray(transform.position, Vector3.down);

		Debug.DrawRay (transform.position, Vector3.down * height);

		if (Physics.Raycast(lookDown, out hit, height)){
			if (hit.collider.tag == "ground"){
				GetComponent<Renderer> ().material.color = Color.green;
			}
		}
	}
}
