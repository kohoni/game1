using UnityEngine;
using System.Collections;

public class Boost : MonoBehaviour {
	public float speed;
	public bool isPlaying = true;

	public float accelerationZ;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
	  if (isPlaying) {
			    //if (Input.GetKeyDown (KeyCode.S)) {
					  float teraspeed = speed + (accelerationZ * Time.deltaTime);
			    	gameObject.GetComponent<Rigidbody>().AddForce(0,0,teraspeed);
			    /*}
	  	      FindObjectOfType<Score> ().AddDistance();*/
	  }
	}
}
