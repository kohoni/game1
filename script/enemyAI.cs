using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class enemyAI : MonoBehaviour {

	public float speed = 10f;
	public float rotationSmooth = 1f; 
	public float levelist;
	public Transform player;
	public float teraspeed;
	public bool IsPlaying = true;
	public GameObject waiting;
	public GameObject gameover;
	private AudioSource audioSource;
	public AudioClip warai;
	public AudioClip nigasanai;
	public AudioClip himei;
	//AudioSource findyou;
	//AudioSource himei;


	// Use this for initialization
	void Start () {
		//waiting.SetActive (false);
		waiting.SetActive(false);
		gameover.SetActive (false);
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = warai;
		audioSource.loop = true;
		audioSource.Play ();
		//himei = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

		if (IsPlaying == true) {
			levelist = levelist + speed * Time.deltaTime;
			float score = levelist * 100;

			if (PlayerPrefs.GetFloat ("highlived") < score) {
				PlayerPrefs.SetFloat ("highlived", score);
			}
		

			// プレイヤーの方向を向く
			Quaternion targetRotation = Quaternion.LookRotation (player.position - transform.position);
			transform.rotation = Quaternion.Slerp (transform.rotation, targetRotation, Time.deltaTime * rotationSmooth);

			teraspeed = teraspeed + speed * Time.deltaTime;

			// 前方に進む
			transform.Translate (Vector3.forward * teraspeed);

			//Debug.Log (teraspeed);
		} else {
			/*gameover.SetActive (true);
			audioSource.clip = nigasanai;
			audioSource.Play ();*/
			//himei.Play ();
		}
	}

	void OnCollisionEnter(Collision c)
	{
		// レイヤー名を取得
		string layerName = LayerMask.LayerToName(c.gameObject.layer);

		// レイヤー名がBullet (Enemy)の時は弾を削除
		if( layerName == "Player")
		{
			waiting.SetActive (true);
			audioSource.clip = nigasanai;
			audioSource.loop = false;
			audioSource.spatialBlend = 0;
			audioSource.Play ();
			IsPlaying = false;
			Invoke ("himeidayo", 7.0f);
			//Destroy (gameObject);
		}

	}

	void himeidayo()
	{
		waiting.SetActive (false);
		gameover.SetActive (true);
		audioSource.clip = himei;
		audioSource.loop = false;
		audioSource.spatialBlend = 0;
		audioSource.Play ();
		Invoke ("end", 4.4f); 
	}

	void end()
	{
		Debug.Log ("end");
		Application.Quit(); 
	}
}
