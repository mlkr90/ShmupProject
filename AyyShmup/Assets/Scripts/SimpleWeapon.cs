using UnityEngine;
using System.Collections;

public class SimpleWeapon : IWeapon {
	private GameObject projectilePrefab;
	public SimpleWeapon(GameObject projectile)
	{
		projectilePrefab = projectile;
	}

	public void Fire (Vector2 position)
	{
		GameObject.Instantiate (projectilePrefab, position, Quaternion.identity);
	}
}
