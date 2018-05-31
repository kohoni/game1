using UnityEngine;
using System.Collections;

public class Move5 : MonoBehaviour {
    public float speed;
	Rigidbody rb;
	public float teraspeed;
	public bool IsPlaying = true;
	//public bool isPlaying = true;

	// Use this for initialization
	void Start () {
  		rb = gameObject.GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {
		if (IsPlaying == true) {
			if (Input.GetKey (KeyCode.Z)) {
				Vector3 pos = transform.position;
				pos.x = -30;
				transform.position = pos;
			}
			if (Input.GetKey (KeyCode.X)) {
				Vector3 pos = transform.position;
				pos.x = 0;
				transform.position = pos;
			}
			if (Input.GetKey (KeyCode.C)) {
				Vector3 pos = transform.position;
				pos.x = 30;
				transform.position = pos;
			}
			//automatic movement
			teraspeed = teraspeed + (speed * Time.deltaTime);
			transform.position += new Vector3 (0.0f, 0.0f, teraspeed);
		}
	}

	// ぶつかった瞬間に呼び出される
	void OnCollisionEnter(Collision c)
	{
		// レイヤー名を取得
		string layerName = LayerMask.LayerToName(c.gameObject.layer);

		// レイヤー名がBullet (Enemy)の時は弾を削除
		if( layerName == "Object")
		{
			IsPlaying = false;
			Debug.Log("hit!");
			teraspeed = 0;
		}
			
	}
}
