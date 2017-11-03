using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {

	public GameObject player;

	public float distance = 10f;
	public float height = 10f;

	private bool isChase = true;

	void Start () {
		isChase = true;
		GameManager.instance.OnFaildCallback += StopChase;
	}
	
	// Update is called once per frame
	void Update () {
		if (isChase) {
			this.transform.position = player.transform.position + Vector3.forward * -distance + Vector3.up * height;
			this.transform.LookAt (player.transform);
		}
	}

	public void StopChase () {
		isChase = false;
	}

	public void StartChase () {
		isChase = true;
	}
}
