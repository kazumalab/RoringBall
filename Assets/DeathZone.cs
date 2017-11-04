using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour {

	void OnTriggerEnter (Collider target) {
		if (target.tag == "Player") {
			GameManager.instance.GameOver ();
		}
	}
}
