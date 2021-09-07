using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject lightPfb;
    public GameObject startPos;
    public GameObject particle;
    // Use this for initialization
    void Start()
    {

    }

    public void WhenPlaybuttonClicked()
    {
        Instantiate(lightPfb, startPos.transform.position, Quaternion.identity);
        Instantiate(particle, startPos.transform.position, Quaternion.identity);
    }
}
