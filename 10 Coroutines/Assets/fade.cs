using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade : MonoBehaviour {

	void Start (){

	}

	void Update(){
		if (Input.GetKeyDown("f")){
			StartCoroutine("Fade");
		}
	}

	IEnumerator Fade (){
		for (float f = 1f; f >=0; f -= 0.1f){
			Color c = GetComponent<Renderer>().material.color;
			c.a = f;
			GetComponent<Renderer>().material.color = c;
			yield return null;
		}
	}
}
	