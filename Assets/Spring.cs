using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour {

	public float JumpPower = 10f;

	void OnTriggerEnter (Collider target) {
		if (target.tag == "Player") {
			Rigidbody rb = target.GetComponent<Rigidbody> ();
			rb.AddForce (Vector3.up * JumpPower, ForceMode.Impulse);
		}
	}
}
