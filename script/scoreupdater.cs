using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreupdater : MonoBehaviour {

	public GameObject Player;
	public Text Score;
	private int score = 0;
	private int high = 0;
	private string hig = "high";
	public bool IsPlaying = true;
	public GameObject gameover;

	void Start()
	{
		gameover.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{   
		if (IsPlaying == true) {

			int score = (int)Player.transform.localPosition.z;
			Score.text = score + "km";

			if (PlayerPrefs.GetInt("highsaaaaaa") < score) {
				PlayerPrefs.SetInt("highsaaaaaa",score);
			}
			//Save();
		}
	}

	void OnCollisionEnter(Collision c)
	{
		// レイヤー名を取得
		string layerName = LayerMask.LayerToName(c.gameObject.layer);

		// レイヤー名がBullet (Enemy)の時は弾を削除
		if( layerName == "Object")
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

		GetComponent<AudioSource> ().Play();


		Debug.Log(PlayerPrefs.GetInt("highs"));

		Invoke ("Gotoresult", 2.0f);
	}

	// ハイスコアの保存
	/*public void Save ()
	{
		// ハイスコアを保存する
		PlayerPrefs.SetInt ("hig", high);

		// ゲーム開始前の状態に戻す
		//Initialize ();
	}*/

	void Gotoresult()
	{
		SceneManager.LoadScene ("title");
	}
}
