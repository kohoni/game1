using UnityEngine;
using System.Collections;

public class Escape : MonoBehaviour {

	void Update (){ 
		if(Input.GetKeyDown(KeyCode.Escape))
		Application.Quit(); 
		if (Input.GetKeyDown (KeyCode.P))
			Application.LoadLevel ("title"); 
	} 

}
