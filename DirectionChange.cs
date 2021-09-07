using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionChange : MonoBehaviour {
    public GameObject lightPFB;
    public float Velocity;
    public Rigidbody2D rd;
    public bool locker = false;
    public bool posLocker = false;

	// Use this for initialization
	void Start () {
       // Velocity = GameObject.FindWithTag("ControllTower").GetComponent<gamectrl>().speed;
		
	}
    void Update()
    {
        if (posLocker)
        {
            lightPFB.transform.position = this.gameObject.transform.position;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Light_W" && locker == false)
        {
            lightPFB = collision.gameObject;
            posLocker = true;
            lightPFB = collision.gameObject;
            //collision.GetComponent<Rigidbody2D>().simulated = false;
           // collision.transform.position = transform.position;
            locker = true;
          //  Destroy(lightPFB);
            StartCoroutine(FixedVector());
        }
    }

    IEnumerator FixedVector()
    {
        yield return new WaitForSeconds(1);

        posLocker = false;
        Instantiating();
        Destroy(lightPFB);
    }

    void Instantiating()
    {
        GameObject FixedvectorObj = Instantiate(lightPFB, transform.position, Quaternion.identity);
        FixedvectorObj.name = "Light_Prefab";
        FixedvectorObj.GetComponent<Rigidbody2D>().AddForce(-transform.right * Time.deltaTime * Velocity);
    }

    // Update is called once per frame
}
