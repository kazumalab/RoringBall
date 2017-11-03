using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {

	public GameObject player;

	public float distance = 10f;
	public float height = 10f;
	
	// Update is called once per frame
	void Update () {
		this.transform.position = player.transform.position + Vector3.forward * -distance + Vector3.up * height;
		this.transform.LookAt (player.transform);
	}
}
