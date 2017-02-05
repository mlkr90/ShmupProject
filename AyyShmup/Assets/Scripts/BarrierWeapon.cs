using UnityEngine;
using System.Collections;

public class BarrierWeapon : IWeapon {

	private GameObject barrierPrefab;
	public BarrierWeapon(GameObject barrier)
	{
		barrierPrefab = barrier;
	}

	public void Fire(Vector2 position)
	{
		GameObject.Instantiate (barrierPrefab, position, Quaternion.identity);
	}
}
