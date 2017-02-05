using UnityEngine;
using System.Collections;

public class barrierBehaviour : MonoBehaviour {
	private float spawnTime;
	void Start() {
		spawnTime = Time.time;
	}

	void Update () {
		
		if (Time.time > spawnTime + 1) {
			Destroy (gameObject);
		}
	}
}
