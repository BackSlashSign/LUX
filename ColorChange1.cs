using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Red")
        {
            this.tag = coll.gameObject.tag;
        }
        if (coll.gameObject.tag == "Blue")
        {
            this.tag = coll.gameObject.tag;
        }
        if (coll.gameObject.tag == "Green")
        {
            this.tag = coll.gameObject.tag;
        }
        if (coll.gameObject.tag == "White")
        {
            this.tag = coll.gameObject.tag;
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Redkey" && this.gameObject.tag == "Red")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
        if (col.gameObject.tag == "Greenkey" && this.gameObject.tag == "Green")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
        if (col.gameObject.tag == "Bluekey" && this.gameObject.tag == "Blue")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
    }
}
