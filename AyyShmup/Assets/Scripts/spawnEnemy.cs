using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour {

	public GameObject smallShip;
	public GameObject bigShip;
	public float smallShipSpawnInterval = 2;
	public float bigShipSpawnInterval = 5;

	private float timeOld = 0;
	private float timeOld2 = 0;
	private int rn = 0;

	
	// Update is called once per frame
	void Update () {
		rn = Random.Range (-11, 11);
		if (Time.time > timeOld + smallShipSpawnInterval) {
			GameObject.Instantiate (smallShip, new Vector2(gameObject.transform.position.x - rn, gameObject.transform.position.y), Quaternion.Euler(new Vector3(180,0,0)));
			timeOld = Time.time;
			rn = Random.Range (-11, 11);
		}
		if (Time.time > timeOld2 + bigShipSpawnInterval) {
			GameObject.Instantiate (bigShip, new Vector2(gameObject.transform.position.x - rn, gameObject.transform.position.y), Quaternion.Euler(new Vector3(180,0,0)));
			timeOld2 = Time.time;
			rn = Random.Range (-11, 11);
		}
	}
}
