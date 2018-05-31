using UnityEngine;
using System.Collections;

public class gamestart : MonoBehaviour {

	public GameObject start;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.T)) {
			start.transform.Translate(0, 2.0f, 0);
			Debug.Log ("start");
		}
	}
}
