﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーン遷移扱う

public class GameOverSceneManager : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		
	}

	//Retry押された時に呼ばれる関数
	public void RetryButton()
	{
		SceneManager.LoadScene("Main");///Mainシーンに移動
	}
}
