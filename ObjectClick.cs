using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private GameObject GetClickedObject () {
		RaycastHit hit;
		GameObject target = null;

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		if (true == (Physics.Raycast(ray.origin, ray.direction * 10, out hit))) {
			target = hit.collider.gameObject;
		}
		return target;

	}
}
