using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerWeaponManager : MonoBehaviour {
	public float barrierCooldown = 5f;
	public GameObject simpleWeaponProjectile;
	public GameObject barrierObject;
	public AudioSource fireEffect;
	public AudioSource collision;

	private List<IWeapon> activeWeapons = new List<IWeapon> ();
	private List<IWeapon> activeBarriers = new List<IWeapon>();
	private float temptime = -5;

	// Use this for initialization
	void Start () {
		activeWeapons.Add (new SimpleWeapon (simpleWeaponProjectile));
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			foreach (IWeapon w in activeWeapons) {
				w.Fire (transform.position);
				fireEffect.Play ();
			}
		}
		if (Time.time > temptime + barrierCooldown) {
			if (Input.GetButtonDown ("Jump")) {
				foreach (IWeapon w in activeBarriers) {
					w.Fire (transform.position);
				}
				temptime = Time.time;
			}
		}

	}

	public void AddWeapon (PlayerWeaponEnum weaponType) {
		Debug.Log ("Added wep");
		collision.Play ();
		switch (weaponType) {
			case PlayerWeaponEnum.Barrier:
				activeBarriers.Add (new BarrierWeapon (barrierObject));
				break;
			case PlayerWeaponEnum.UberWeapon:
				activeWeapons.Add (new UberWeapon (simpleWeaponProjectile));
				break;
			default:
				Debug.Log ("WeaponType " + weaponType + " not implemented.");
				return;
		}
	}
}
