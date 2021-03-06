using UnityEngine;
using System.Collections;

public class TitleController4 : MonoBehaviour {
	public AudioClip bgm;
	public AudioClip hell;
	public GameObject gotohell;
	private AudioSource audioSource;
	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource> ();
		audioSource.clip = bgm;
		audioSource.Play ();
		gotohell.SetActive (false);
	}
	
	// Update is called once per frame
/*	void Update () {

	}*/

	void OnCollisionEnter(Collision c)
	{
		// レイヤー名を取得
		string layerName = LayerMask.LayerToName(c.gameObject.layer);

		// レイヤー名がBullet (Enemy)の時は弾を削除
		if( layerName == "bullet")
		{
			Gotohell ();
		}

	}

	void Gotohell()
	{
		Vector3 pos = transform.position;
		pos.y = -1000;
		transform.position = pos;
		audioSource.clip = hell;
		audioSource.Play ();
		gotohell.SetActive (true);
		Invoke ("gaming2", 7.0f);
	}

	void gaming2()
	{
		Application.LoadLevel ("gaming2");
	}
}
