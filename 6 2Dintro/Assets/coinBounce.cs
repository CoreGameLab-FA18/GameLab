using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinBounce : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	float speed = 10f;
//	float height = 0.5f;

	void Update () {
//		transform.Rotate(0, 0, Time.deltaTime*100);
//		transform.Translate (Vector2.up * (Mathf.Sin(Time.time*10)/80));
		Vector2 pos = transform.position;
		float newY = Mathf.Sin (Time.time * speed)*0.25f;
		transform.position = new Vector2 (pos.x, newY);

	}

}
