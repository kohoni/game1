using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreupdater1 : MonoBehaviour {

	public GameObject Player;
	public Text Score;
	public bool IsPlaying = true;
	public GameObject gameover;
	private int score = 0;

	void Start()
	{
		gameover.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{   
		if (IsPlaying == true) {

			int score = (int)Time.time * 100;
			Score.text = score + "秒";

			if (PlayerPrefs.GetInt ("highlive") < score) {
				PlayerPrefs.SetInt ("highlive", score);
			}
			//Save();
		} else 
		{
			gameover.SetActive (true);
		}
	}

	void OnCollisionEnter(Collision c)
	{
		// レイヤー名を取得
		string layerName = LayerMask.LayerToName(c.gameObject.layer);

		// レイヤー名がBullet (Enemy)の時は弾を削除
		if( layerName == "enemy")
		{
			IsPlaying = false;
			Gameover ();
		}

	}

	/*int CalMeter()
	{
		return (int)Player.transform.position.z;
	}*/

	void Gameover()
	{
		gameover.SetActive (true);

		/*if (high < score) 
		{
			high = score;
			Save();
		}*/

		//GetComponent<AudioSource> ().Play();


		Debug.Log(PlayerPrefs.GetInt("shinnda"));

		//Invoke ("Gotoresult", 2.0f);
	}

	// ハイスコアの保存
	/*public void Save ()
	{
		// ハイスコアを保存する
		PlayerPrefs.SetInt ("hig", high);

		// ゲーム開始前の状態に戻す
		//Initialize ();
	}*/

	/*void Gotoresult()
	{
		Application.LoadLevel ("title");
	}*/
}
