using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
	public float moveSpeed = 1;

	// Update is called once per frame
	void Update () {
		transform.Translate (0,moveSpeed * Time.deltaTime, 0);
	}
}
