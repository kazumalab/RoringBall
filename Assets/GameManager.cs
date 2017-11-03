using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	public delegate void FaildCallback ();
	public FaildCallback OnFaildCallback;

	private readonly string CLEAR_SCENE_NAME = "GameClear";
	private readonly string FAILD_SCENE_NAME = "GameOver";

	void Start () {
		if (instance == null) {
			instance = this;
		}
	}

	public void GameClear () {
		SceneManager.LoadScene (CLEAR_SCENE_NAME);
	}

	public void GameOver () {
		StartCoroutine (OnFaild());
	}

	private IEnumerator OnFaild () {
		if (OnFaildCallback != null) {
			OnFaildCallback ();
		}
		yield return new WaitForSeconds (1f);
		SceneManager.LoadScene (FAILD_SCENE_NAME);
	}
}
