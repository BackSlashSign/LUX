using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour {
	public Texture[] textures;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D col) {
		Debug.Log ("colorchamge");
		if(col.tag =="White") {
			gameObject.GetComponentInChildren<MeshRenderer> ().material.mainTexture = textures [0];
			this.tag = "White";
			Debug.Log (this.tag);
		}if(col.tag =="Red") {
			gameObject.GetComponentInChildren<MeshRenderer> ().material.mainTexture = textures [1];
			this.tag = "Red";
		}if(col.tag =="Green") {
			gameObject.GetComponentInChildren<MeshRenderer> ().material.mainTexture = textures [2];
			this.tag = "Green";
		}if(col.tag =="Blue") {
			gameObject.GetComponentInChildren<MeshRenderer> ().material.mainTexture = textures [3];
			this.tag = "Blue";
		}
	}
}
