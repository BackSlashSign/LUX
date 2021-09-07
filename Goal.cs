using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour {
    public GameObject[] colorLock;
    public GameObject ClearWindow;
    public bool clearYN = false;
    public bool keyOn = false;

    public Text clearText;

	// Use this for initialization
	void Start () {
        colorLock = GameObject.FindGameObjectsWithTag("KEY");
        foreach (GameObject a in colorLock);
        ClearWindow.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if(GameObject.FindGameObjectsWithTag("KEY").Length <= 0)
        {
            keyOn = true;
        }
    }
	void OnTriggerStay2D (Collider2D coll) {
        if (keyOn == true && coll.name == "Light_Prefab")
        {
            Time.timeScale = 0.0f;
            ClearWindow.SetActive(true);
        }
	/*	Debug.Log ("gaols");
		if (col.tag == "Goal" && LightEmit.keyActivate == true) {
			Destroy (this.gameObject);
		}
		if (col.tag == this.tag) {
			Destroy (this.gameObject);
			Destroy (GameObject.Find("BlueKey"));
			LightEmit.keyActivate = true;
		}
		if (col.tag == this.tag) {
			string coltag = col.tag;
			this.tag = coltag;
		}*/
	}
}
