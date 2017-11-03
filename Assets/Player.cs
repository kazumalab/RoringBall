using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private Rigidbody rb;
	private float Speed = 10f;

	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float dx = Input.GetAxis ("Horizontal");
		float dy = Input.GetAxis ("Vertical");

		Vector3 direction = Vector3.right * dx + Vector3.forward * dy;
		rb.AddForce (direction * Speed);
	}
}
