using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StageGenerater : MonoBehaviour {

	//生成されるオブジェクトの長さ
	const int StageTipSize = 150;

	int cuttentTipIndex;
	//プレイヤーの位置
    public Transform Player;
	//オブジェクトを複製するのに必要
    public GameObject[] stageTips;
	//最初にどれだけオブジェクトを生成しておくか
    public int stageTipIndex;
	//生成先読みするオブジェクトの数
    public int preInstantiate;
	//古いオブジェクト削除
    public List<GameObject> generatedStageList = new List<GameObject>();
	// Use this for initialization
	void Start () {
		
		cuttentTipIndex = stageTipIndex - 1;
		//void UpdataStage参照
		UpdateStage(preInstantiate);
	}
	
	// Update is called once per frame
	void Update () {
		//プレイヤーの位置から現在のステージチップのインデックスを計算
		int charaPositionIndex = (int)(Player.position.z/StageTipSize);
		//次のステージチップに入ったらステージの更新処理を行う
		if(charaPositionIndex + preInstantiate > cuttentTipIndex+2){
			UpdateStage(charaPositionIndex + preInstantiate);
		}
	}

	//指定のインデックスまでのステージチップを生成して管理下に置く。
	void UpdateStage(int toTipIndex)
	{
		if(toTipIndex <= cuttentTipIndex) return;

		// 指定のステージチップまでを作成
		for(int i = cuttentTipIndex +1; i <= toTipIndex; i++)
		{
			GameObject stageObject = GenerateStage(i);

			//生成したステージチップを管理リストに追加
			generatedStageList.Add(stageObject);
		}
		//ステージ保持上限内になるまで古いステージを削除
		while(generatedStageList.Count > preInstantiate) DestroyOldestStage();
		cuttentTipIndex = toTipIndex;
	}

	//ランダム生成
	GameObject GenerateStage(int tipIndex)
	{
		int nextStageTip = Random.Range(0,stageTips.Length);

		GameObject stageObject = (GameObject)Instantiate(
			stageTips[nextStageTip],
			new Vector3(0,0,tipIndex * StageTipSize),
			Quaternion.identity
			);

			return stageObject;
	}

	//一番古いステージを削除
	void DestroyOldestStage()
	{
		GameObject oldStage = generatedStageList[0];
		generatedStageList.RemoveAt(0);
		Destroy(oldStage);
	}

}
