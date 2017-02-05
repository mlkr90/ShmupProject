using UnityEngine;
using System.Collections;

public class UberWeapon : IWeapon {
	private GameObject projectilePrefab;
	public UberWeapon(GameObject projectile)
	{
		projectilePrefab = projectile;
	}

	public void Fire (Vector2 position)
	{
		//GameObject.Instantiate (projectilePrefab, position, Quaternion.identity);
		GameObject.Instantiate (projectilePrefab,new Vector2(position.x + 1, position.y), Quaternion.identity);
		GameObject.Instantiate (projectilePrefab,new Vector2(position.x - 1, position.y), Quaternion.identity);
	}
}
