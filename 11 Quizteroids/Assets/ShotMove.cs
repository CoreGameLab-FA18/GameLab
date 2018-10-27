using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMove : MonoBehaviour {

	public float shotSpeed = 15;

	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * Time.deltaTime * shotSpeed);
	}
}
