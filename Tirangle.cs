using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tirangle : MonoBehaviour {

	public GameObject lightPrefab; // do not insert object in Unity Inspector Window. use Start Method Instead
    public GameObject Particle_; 

    public int Locker = 1;
    public int PosLock = 0;


    float speed = 300f;

	public Transform up;
	public Transform down;

	void Awake () {

	}
	void Start () {
		

	}
    public void OnStarting()
    {
        Locker = 1;
        PosLock = 0;
    }


    void Update()
    {
        //lightPrefab = GameObject.FindWithTag("Light_W");
        if (PosLock == 1)
        {
            lightPrefab.transform.position = this.gameObject.transform.position;
        }
    }

	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.tag == "Light_W" && Locker == 1) {
            lightPrefab = col.gameObject;
            PosLock = 1;
            Locker = 0;
            StartCoroutine(Fixedposition());
        }
    }
    IEnumerator Fixedposition()
    {
        yield return new WaitForSeconds(1);
        //lightPrefab = GameObject.FindWithTag("Light_W");
        PosLock = 0;
		Instantiate(Particle_, this.gameObject.transform.position, Quaternion.identity);
        Particle_.SetActive(true);
        //lightPrefab = GameObject.FindWithTag("Light_W");
        UpAddForce();
        DonwAddForce();
        Destroy(lightPrefab);
        Destroy(GameObject.FindWithTag("Particle_B"), 1f);
    }
    void UpAddForce()
    {
		GameObject UpLight = Instantiate(lightPrefab, transform.position,Quaternion.identity);
        UpLight.name = "Light_Prefab";
        UpLight.GetComponent<lightctrl>().enabled = false;
		UpLight.GetComponent<Rigidbody2D>().AddForce((transform.right + transform.up).normalized * speed);
        UpLight.GetComponent<CircleCollider2D>().enabled = true;
    }
    void DonwAddForce()
    {
		GameObject DownLight = Instantiate(lightPrefab, transform.position,Quaternion.identity);
        DownLight.name = "Light_Prefab";
        DownLight.GetComponent<lightctrl>().enabled = false;
		DownLight.GetComponent<Rigidbody2D>().AddForce((transform.right - transform.up).normalized * speed);
        DownLight.GetComponent<CircleCollider2D>().enabled = true;
    }
}

