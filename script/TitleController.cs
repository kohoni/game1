using UnityEngine;
using System.Collections;

public class TitleController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<AudioSource> ().Play();
			Invoke ("Letusgo", 1.0f);
		}
	}

	void Letusgo(){
		Application.LoadLevel ("gaming");
	}
}
