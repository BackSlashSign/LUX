using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroll : MonoBehaviour {
    public Vector3 startPos;
    public Transform endPos;
    public float speed = 1.0f;
    public float this_X;                //when x to start x

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(-1*Time.deltaTime*speed, 0, 0);
        if (this.transform.position.x <= this_X)
        {
            this.gameObject.transform.position = startPos;
        }
	}
}
