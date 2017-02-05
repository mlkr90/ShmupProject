using UnityEngine;
using System.Collections;

public class bulletHit : MonoBehaviour {
	public GameObject explosionPrefab;
	public int damageValue = 1;
	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.tag == "Enemy") {
			GameObject.Instantiate (explosionPrefab, gameObject.transform.position, Quaternion.identity);
			Destroy (gameObject);

			c.gameObject.GetComponent<IDamageable>().Damage (damageValue);
		}
	}
}
