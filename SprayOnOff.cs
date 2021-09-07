using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprayOnOff : MonoBehaviour {
    public GameObject whiteSpray;
    public GameObject redSpray;
    public GameObject greenSpray;
    public GameObject blueSpray;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.tag == "White")
        {
            whiteSpray.SetActive(true);
            redSpray.SetActive(false);
            greenSpray.SetActive(false);
            blueSpray.SetActive(false);
        }
        if (this.tag == "Red")
        {
            whiteSpray.SetActive(false);
            redSpray.SetActive(true);
            greenSpray.SetActive(false);
            blueSpray.SetActive(false);
        }
        if (this.tag == "Green")
        {
            whiteSpray.SetActive(false);
            redSpray.SetActive(false);
            greenSpray.SetActive(true);
            blueSpray.SetActive(false);
        }
        if (this.tag == "Blue")
        {
            whiteSpray.SetActive(false);
            redSpray.SetActive(false);
            greenSpray.SetActive(false);
            blueSpray.SetActive(true);
        }
    }
}
