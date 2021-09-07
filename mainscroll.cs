using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainscroll : MonoBehaviour {
    public Vector3 StartPos;
    public Vector3 EndPos;
    public float speed = 1.0f;

	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Light_W")
        {
            Destroy(collision.gameObject);
        }
    }
    // Update is called once per frame
    void Update () {
        this.transform.Translate(-1 * Time.deltaTime * speed, 0, 0);
        if (this.transform.position.x <= EndPos.x)
        {
            this.gameObject.transform.position = StartPos;
        }
    }
}
