using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUIElements : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 topLeft = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, 0));
		Vector3 bottomLeft = Camera.main.ViewportToWorldPoint (new Vector3 (0, 1, 0));

		gameObject.transform.position = new Vector3 (topLeft.x + 10, topLeft.y - 10, topLeft.z);
	}
}
