using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
	// スコアを表示するGUIText、子要素に入れるオブジェクト名
	public GUIText scoreGUIText;
	//GameObjectで呼び出します。
	public GameObject Player;

	// ハイスコアを表示するGUIText
	public GUIText highScoreGUIText;

	// スコア
	private float distance = 0;

	private float high = 0;

	// PlayerPrefsで保存するためのキー
	private string hig = "hig";

	private string nowscore = "nowscore";

	void Start ()
	{
		Initialize ();
	}

	void Update ()
	{ 
		if (high < distance) {
			high = distance;
		}

		// スコア・ハイスコアを表示する
		scoreGUIText.text = distance.ToString ()+"m";
		highScoreGUIText.text = high.ToString ()+"m";
		Save();
	}

	private void Initialize()
	{
		// スコアを0に戻す
		distance = PlayerPrefs.GetFloat ("nowscore",0);

		// ハイスコアを取得する。保存されてなければ0を取得する。
		high = PlayerPrefs.GetFloat ("hig", 0);
	}


	// ポイントの追加
	public void AddDistance()
	{
		distance = Player.transform.localPosition.z;
		Debug.Log (distance);
	}

	// ハイスコアの保存
	public void Save ()
	{
		// ハイスコアを保存する
		PlayerPrefs.SetFloat ("hig", high);

		// ゲーム開始前の状態に戻す
		//Initialize ();
	}
	/*プレイヤーにスコアの変数　public int を導入
	 * if(GetKeyDown P){
	 * 		// スコアコンポーネントを取得してポイントを追加
	FindObjectOfType<Distance>().AddDistance(renda);
	* }

*/

}