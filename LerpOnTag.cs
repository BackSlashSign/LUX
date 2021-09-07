using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpOnTag : MonoBehaviour {

    private float Trace = 20.0f; //Velocity 
    public GameObject LightPrefab;

	void Start()
	{
		LightPrefab = GameObject.FindWithTag ("Light_W");
	}

	void Update()
	{
        if (LightPrefab.gameObject.tag == "Light_W") //First Tag value
        {
            Vector3 pos = Vector3.Lerp((Vector3)transform.position, (Vector3)LightPrefab.transform.position, Time.fixedDeltaTime * Trace);
            transform.position = new Vector3(pos.x, pos.y,pos.z );
        }
        else if (LightPrefab.tag == "Light_G") 
        {
            Vector2 pos = Vector2.Lerp((Vector2)transform.position, (Vector2)LightPrefab.transform.position, Time.fixedDeltaTime * Trace);
            transform.position = new Vector3(pos.x, pos.y, transform.position.y);
        }
        else if (LightPrefab.tag == "Light_B")
        {
            Vector2 pos = Vector2.Lerp((Vector2)transform.position, (Vector2)LightPrefab.transform.position, Time.fixedDeltaTime * Trace);
            transform.position = new Vector3(pos.x, pos.y, transform.position.y);
        }
        else if (LightPrefab.tag == "Light_R")
        {
            Vector2 pos = Vector2.Lerp((Vector2)transform.position, (Vector2)LightPrefab.transform.position, Time.fixedDeltaTime * Trace);
            transform.position = new Vector3(pos.x, pos.y, transform.position.y);
        }
    }

}
