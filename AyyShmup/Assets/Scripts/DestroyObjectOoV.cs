using UnityEngine;
using System.Collections;

public class DestroyObjectOoV : MonoBehaviour {

	void Update () {
		Vector3 bottomLeft = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, 0));
		Vector3 topRight = Camera.main.ViewportToWorldPoint (new Vector3 (1, 1, 0));

		if((transform.position.y < bottomLeft.y ) ||
			(transform.position.y > topRight.y))
		{
			Destroy(gameObject);
		}
	}
}
