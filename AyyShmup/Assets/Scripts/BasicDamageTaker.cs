using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BasicDamageTaker : MonoBehaviour, IDamageable {
	public GameObject explosion;
	public int hitPoints = 1;
	public int scoreValue = 100;

	public void Damage(int value)
	{
		
		if(!ApplicationModel.gracePeriod) {
			if (gameObject.tag == "Player") {
				GameObject.Find ("GameManager").GetComponent<GameManager> ().RemoveHealth (value);
				hitPoints -= value;
			}
		}
		if(gameObject.tag == "Enemy") {
			hitPoints -= value;
		}

		if (hitPoints <= 0) {
			Kill ();
		}
	}

	public void Kill() {
		Destroy (gameObject);
		if (gameObject.tag == "Enemy") {
			GameObject.Instantiate (explosion, gameObject.transform.position, Quaternion.identity);

			GameObject.Find ("GameManager").GetComponent<GameManager> ().AddScore (scoreValue);
		}
		if (gameObject.tag == "Player") {
			GameObject.Find ("GameManager").GetComponent<GameManager> ().RespawnShip ();
		}
	}


}
