using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightctrl : MonoBehaviour {
    public float speed = 2000.0f;
	//public Vector3 vector_pos;
	private GameObject FixedPosition;
    public GameObject lightprefab;
    public GameObject StartPos;

	public bool Vectorchecker = false;
    // Use this for initialization
    private void Awake()
    {
        StartPos = GameObject.FindWithTag("StartPos");
    }
    void Start () {
	//FixedPosition = GameObject.FindWithTag ("Light_W");
	//	Vector3 vector_pos = FixedPosition.transform.position;

		firelight ();
	}

	void firelight() {
		this.GetComponent<Rigidbody2D> ().AddForce (StartPos.transform.right * Time.deltaTime * speed);
	}

	// Update is called once per frame
	void Update () {
//		if (Vectorchecker) {
//			lightprefab.gameObject.transform.position = FixedPosition.transform.position;
//		}
	}
}
