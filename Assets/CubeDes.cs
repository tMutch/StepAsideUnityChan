using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDes : MonoBehaviour {
	//Unityちゃん追従させるコンポーネントを入れる
//	private Rigidbody myRigidbody;
	//前進するための力
//	private float forwardForce = 800.0f;

	// Use this for initialization
	void Start () {
		//Rigdbodyコンポーネントを取得
//		this.myRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		//削除する壁に前方向の力を加える
//		this.myRigidbody.AddForce (this.transform.forward * this.forwardForce);
	}

	void OnTriggerEnter(Collider other) {
		//壁に触れたら削除する
		if (other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag" || other.gameObject.tag == "CoinTag"){
		Destroy (other.gameObject);
		}
	}
}
