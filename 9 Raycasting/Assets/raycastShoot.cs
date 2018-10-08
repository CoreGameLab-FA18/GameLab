using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastShoot : MonoBehaviour {

	public Transform gunEnd;
	private Camera fpsCam;
	private LineRenderer laserLine;


	void Start () {
		laserLine = GetComponent<LineRenderer> ();
		fpsCam = GetComponentInParent<Camera> ();

	}
	
	void Update () {
		if (Input.GetButton ("Fire1")) { // use GetButtonDown for quick fire effect

			laserLine.enabled = true; //start laser

			Vector3 rayOrigin = fpsCam.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, 0.0f)); // find the middle of the fpsCam view

			RaycastHit hit;

			laserLine.SetPosition (0, gunEnd.position); // set start point of laser to gunEnd

			if (Physics.Raycast (rayOrigin, fpsCam.transform.forward, out hit, 100f)) {
				laserLine.SetPosition (1, hit.point); // set the end point of laser to where it's hitting a collider
				if (hit.collider.tag == "cube") {
					hit.collider.GetComponent<Renderer> ().material.color = Color.red;
				}
			
			} else {
				laserLine.SetPosition (1, rayOrigin + (fpsCam.transform.forward * 100f));
			}

		} else {
			laserLine.enabled = false; // turn off laser
		}		
	}
}
