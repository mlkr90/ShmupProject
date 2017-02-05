using UnityEngine;
using System.Collections;

public class bulletBehaviour : MonoBehaviour {
	public float bSpeed = 3;
	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Rigidbody2D> ().velocity = Vector2.up * bSpeed;
	}

}
