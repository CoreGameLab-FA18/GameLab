using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeZoom : MonoBehaviour {

	public GameObject cube, sphere;
	Animator anim;
	float dist;

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		dist = Vector3.Distance (cube.transform.position, sphere.transform.position);
		anim.SetFloat ("doZoom", dist);
		
	}
}
