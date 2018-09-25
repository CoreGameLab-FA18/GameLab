using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {
	public GameObject cube;
	GameObject cubeClone;

	void Start () {
	
		cubeClone = Instantiate (cube, transform.position, Quaternion.identity)as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
