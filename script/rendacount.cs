using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class rendacount : MonoBehaviour {



	public int count = 0;

	public float rendacounter = 0;

	public TextMesh rendaa;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.K)) {
			count += 1;
			Debug.Log (count);
		}
		rendacounter = count / Time.time;
		rendaa.text = rendacounter + "/s";

	}
}
