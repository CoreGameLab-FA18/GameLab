using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidMove : MonoBehaviour {

	float posX, posY;
	float speed;
	float hp;

	// Use this for initialization
	void Start () {

		posX = Random.Range (-14, 14);
		posY = Random.Range (-11, 11);
		speed = 2;
		hp = Random.Range (1, 4);

		Vector3 euler = transform.eulerAngles;
		euler.y = Random.Range(0f, 360f);
		transform.eulerAngles = euler;
		transform.position = new Vector3 (posX, 0, posY);
		transform.localScale = new Vector3 (hp, hp, hp);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * Time.deltaTime * speed);

		resetPos ();
	}

	void resetPos(){
		if (transform.position.x <= -14) {
			transform.position = new Vector3(13, transform.position.y, transform.position.z);
		}
		if (transform.position.x >= 14) {
			transform.position = new Vector3(-13, transform.position.y, transform.position.z);
		}
		if (transform.position.z <= -11) {
			transform.position = new Vector3(transform.position.x, transform.position.y, 10);
		}
		if (transform.position.z >= 11) {
			transform.position = new Vector3(transform.position.x, transform.position.y, -10);
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "shot") {
			if (hp > 0) {
				hp -= 1;
				transform.localScale = new Vector3 (hp, hp, hp);
			} else {
				Destroy (this.gameObject);
			}
			Destroy (other.gameObject);
		}
	}
}
