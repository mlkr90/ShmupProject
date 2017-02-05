using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponPowerUp : MonoBehaviour {
	public PlayerWeaponEnum weaponType;

	void OnTriggerEnter2D(Collider2D c) {
		if (c.gameObject.tag == "Player") {
			Debug.Log ("Powerup");
			c.gameObject.GetComponent<PlayerWeaponManager> ().AddWeapon (weaponType);
			Destroy (gameObject);
		}
	}
}
