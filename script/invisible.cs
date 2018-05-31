using UnityEngine;
using System.Collections;

public class invisible : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!GetComponent<Renderer> ().isVisible) 
		{
			Destroy (this.gameObject);
		}
	}
}
