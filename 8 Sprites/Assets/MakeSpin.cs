using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSpin : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D other){
		Debug.Log ("collision");
		anim.SetTrigger ("doSpin");
	}
}
