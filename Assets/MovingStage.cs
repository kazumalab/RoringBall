using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingStage : MonoBehaviour {


	public float Amplitude = 1f;
	public float Period = 1f;

	private float time = 0f;
	private Vector3 default_position;

	// Use this for initialization
	void Start () {
		default_position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		transform.position = default_position + (Vector3.up * Amplitude) * Mathf.Sin (Radian ());
	}

	private float Radian () {
		return time * Period;
	}
}
