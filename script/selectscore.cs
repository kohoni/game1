using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class selectscore : MonoBehaviour {

	public Text highscore;
	// Use this for initialization
	void Start () {
		highscore.text = "High Score : " + PlayerPrefs.GetInt ("highsaaaaaa") + "km";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
