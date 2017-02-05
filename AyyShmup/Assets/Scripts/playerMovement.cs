using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {
	public float moveSpeed = 2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector3 move = new Vector3 (0, 0, 0);
		Animator a = gameObject.GetComponent<Animator> ();
		a.SetBool ("left", false);
		a.SetBool ("right", false);

		if(Input.GetKey("left")) {
			move.x = -1;
			a.SetBool ("left", true);
		}
		if (Input.GetKey ("right")) {
			move.x = 1;
			a.SetBool ("right", true);
		}
		if(Input.GetKey("up")) {
			move.y = 1;
		}
		if (Input.GetKey ("down")) {
			move.y = -1;
		}

		Vector3 topLeft = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, 0));
		Vector3 bottomRight = Camera.main.ViewportToWorldPoint (new Vector3 (1, 1, 0));
		Vector3 currentPos = transform.position;
		currentPos += move * Time.deltaTime * moveSpeed;

		currentPos.x = Mathf.Clamp (currentPos.x, topLeft.x, bottomRight.x);
		currentPos.y = Mathf.Clamp (currentPos.y, topLeft.y, bottomRight.y);

		transform.position = currentPos;

		//Debug.Log (topLeft + " . " + bottomRight);


	}
}
