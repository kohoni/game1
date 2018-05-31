using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

	public GameObject tama;

	public Transform muzzle;

	public float speed = 1000;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.K)) {

			GameObject tamas = GameObject.Instantiate (tama)as GameObject;

			Vector3 force;
			force = this.gameObject.transform.forward * speed;

			tamas.GetComponent<Rigidbody> ().AddForce (force);

			tamas.transform.position = muzzle.position;
			Destroy (tamas, 4.0f);
		}

	}
}
