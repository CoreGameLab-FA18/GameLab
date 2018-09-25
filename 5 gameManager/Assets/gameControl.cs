using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 5
using System;
using System.Runtime.Serialization.Formatters.Binary; // essentially unreadable by players because its in binary. unlike playerprefs
using System.IO; // input/output for saving/loading

public class gameControl : MonoBehaviour {

	// 1 - first create variables
	public float health;
	public float experience;

	// 2 - create a control object - needs to be SAME NAME AS SCRIPT NAME
	public static gameControl control;

	void Awake(){
	// 3 - if there's no gamecontrol, make this the game control
		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this;   // this means this script
		} else if (control != this) {
			Destroy (gameObject);  // there can be only one
		}
	}

	// 4 - create labels with our public variables
	void OnGUI(){  
		GUI.Label (new Rect (10, 10, 100, 30), "Health: " + health);
		GUI.Label (new Rect (10, 40, 100, 30), "Experience: " + experience);
	}

	// 5 -
	// could call this in OnDisable() to auto save
	public void Save(){ // making public so other scripts can call Save();
		// create a file and push data to it
		BinaryFormatter bf = new BinaryFormatter();
		// persistentDataPath = secret filepath in unity, a good place to save stuff you don't want people to save
		FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat"); // create a file that we will save to

		// 7 instantiate the class with current data so you can save it
		PlayerData data = new PlayerData();
		data.health = health;
		data.experience = experience;

		bf.Serialize (file, data);  // write player data to file
		file.Close(); // close the file when we finish
	}

	// 8 loading file
	// could call this in OnEnable() to auto load
	public void Load(){
		// check if file exists first
		if (File.Exists(Application.persistentDataPath + "/playerInfo.dat")) {
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open); // opens the file
			PlayerData data = (PlayerData)bf.Deserialize (file); // reads it into an object that we've defined as a player data object
			file.Close();
			health = data.health;
			experience = data.experience;
		}
	}
		
}

// 6 - a clean class object/data container to use to save to a file. 
// cant save gameControl class because its a MonoBehavior. This is a clean one that you can serialize.
[Serializable] // tells unity it is serializable
class PlayerData {
	public float health;
	public float experience;
}
