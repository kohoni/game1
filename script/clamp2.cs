using UnityEngine;
using System.Collections;


public class clamp2 : MonoBehaviour {
	public GameObject Player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			
		Vector3 min = new Vector3(-200, -200,-200);

        // 画面右上のワールド座標をビューポートから取得
		Vector3 max = new Vector3(200, 200,200);

        // プレイヤーの座標を取得
        Vector3 pos = transform.position;

        // プレイヤーの位置が画面内に収まるように制限をかける
        pos.x = Mathf.Clamp (pos.x, min.x, max.x);
        pos.y = Mathf.Clamp (pos.y, min.y, max.y);
		pos.z = Mathf.Clamp (pos.z, min.z, max.z);

        // 制限をかけた値をプレイヤーの位置とする
        transform.position = pos;
	}
}
