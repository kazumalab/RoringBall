using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float dy = Input.GetAxis ("Horizontal");
		float dx = Input.GetAxis ("Vertical");

		Vector3 direction = Vector3.right * dx + Vector3.forward * dy;
		rb.AddForce (direction);
	}
}
