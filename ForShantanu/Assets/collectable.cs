using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour {

	public GameObject wall;
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = wall.GetComponent<Animator> ();
	}
		
	void OnTriggerEnter(Collider other){
		Debug.Log ("triggered");
		anim.SetTrigger ("moveWall");
		Destroy (this.gameObject);
	}
}
