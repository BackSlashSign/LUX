using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTouch : MonoBehaviour {
    bool posFix = false;
    GameObject lightPfb;

	// Use this for initialization
	void Start () {
        posFix = false;
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Light_W")
        {
            lightPfb = collision.gameObject;
            posFix = true;
            Destroy(collision.gameObject,1f);
            Debug.Log(collision.gameObject.tag);
            Debug.Log(collision.gameObject.name);
        }
    }

    // Update is called once per frame
    void Update () {
        if (posFix == true)
        {
            lightPfb.gameObject.transform.position = this.transform.position;
        }
        else if (lightPfb == null)
        {
            posFix = false;
        }
            
		
	}
}
