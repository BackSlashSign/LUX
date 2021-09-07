using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class Sound_Colorchange : MonoBehaviour {
    public AudioClip fireSfx;
    private AudioSource source = null;

	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Light_W")
        {
 //         collision.gameObject.tag = this.tag;
            source.PlayOneShot(fireSfx, 5f);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}

}
