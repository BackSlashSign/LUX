using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightEmit : MonoBehaviour {

	public GameObject lightPrefab;				//"LightPrefab" in Hierachy
	public GameObject startPos;					//"StartPos" in Hierachy
	public GameObject goalPos;					//"GoalPos" in Hierachy
	public float speed = 0f;

	public bool lightIsmoving = false;			//Addforce locker

	Vector3 S_Pos;								//lightPrefab position to startPos position

	public static bool keyActivate;
	public static bool obstacleMoveLock;
	enum State{
		Ready,
		Play,
		Reload
	}
	State Gamestate;
	// Use this for initialization
	void Start () {
        S_Pos = startPos.transform.position;
		Ready ();
	}
	void LateUpdate () {
	}
	void Ready () {
		Gamestate = State.Ready;
		keyActivate = false;
		lightIsmoving = false;
//		Destroy(GameObject.Find("LightPrefab"));
//		Instantiate (lightPrefab, startPos.transform.position, Quaternion.identity);
		lightPrefab.transform.position = S_Pos;
		lightPrefab.SetActive(false);
		Debug.Log("lightIsmoving :" + lightIsmoving);
	}
	public void GameStart () {
		Gamestate = State.Play;
		lightPrefab.SetActive (true);
		lightIsmoving = true;
		lightPrefab.transform.position = S_Pos;
		speed = 300f;
		lightPrefab.GetComponent<Rigidbody2D> ().AddForce (startPos.transform.right * speed);
		Debug.Log ("lightIsmoving :" + lightIsmoving);
	}
	public void Reload () {
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}
	public void PlayButtonClick () {
		if (lightIsmoving == false) {
			GameStart ();
		} else if (lightIsmoving == true) {
//			Destroy(GameObject.Find("LightPrefab"));
			Destroy(GameObject.Find("LightPrefab(Clone)"));
			Destroy(GameObject.Find("LightPrefab(Clone)(Clone)"));
			Ready ();
		}
	}
}
