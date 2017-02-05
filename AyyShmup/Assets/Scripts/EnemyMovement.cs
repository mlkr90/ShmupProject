using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	public float sinAmplitude = 1f;
	public float moveSpeed = 5f;
	void Update () {
		transform.Translate (Mathf.Sin(transform.position.y) * sinAmplitude, moveSpeed * Time.deltaTime, 0);
	}
}
