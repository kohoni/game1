using UnityEngine;
using System.Collections;

public class debugcameramove : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
				if (Input.GetKey(KeyCode.UpArrow)) {
					transform.Translate(0,2.5f,0);
				}
				if (Input.GetKey(KeyCode.DownArrow)) {
					transform.Translate(0,-2.5f,0);
				}
				if (Input.GetKey(KeyCode.RightArrow)) {
					transform.Translate(2.5f,0,0);
				}
				if (Input.GetKey(KeyCode.LeftArrow)) {
					transform.Translate(-2.5f,0,0);
				}
				if (Input.GetKey(KeyCode.W)) {
					transform.Translate(0,0,2.5f);
				}
				if (Input.GetKey(KeyCode.S)) {
					transform.Translate(0,0,-2.5f);
				}
	}
}
