using UnityEngine;
using System.Collections;

public class TitleController0 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<AudioSource> ().Play();
			Invoke ("Gototutorial", 2.0f);
		}
	}

	void Gototutorial(){
		Application.LoadLevel ("tutorial");
	}
}
