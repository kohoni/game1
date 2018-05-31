using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {
	public GameObject bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (bullet.transform.position.z > 1000) 
		{
			Debug.Log ("ok");
			Destroy (bullet);
		}	
	}

}
