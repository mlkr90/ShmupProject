using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCollisionDamage : MonoBehaviour {
	public int damageValue = 20;

	void OnTriggerEnter2D(Collider2D c) {
		if (c.tag == "Player") {
			c.gameObject.GetComponent<IDamageable>().Damage (damageValue);
		}
	}
}
