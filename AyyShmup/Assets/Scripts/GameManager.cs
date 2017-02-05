using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


	private int score = 0;
	private int health = 100;
	public int lives = 2;
	public Text scoreValueObject;
	public Text healthValueObject;
	public GameObject player;
	public GameObject healthIconPrefab;
	public GameObject healthIconHolder;

	void Start() {
		updatePlayerLifeUI ();
		ApplicationModel.gracePeriod = false;
	}

	public void AddScore(int scoreIncrease)
	{
		score += scoreIncrease;
		scoreValueObject.text = score.ToString ();
	}

	public void RemoveHealth(int damageTaken)
	{
		ApplicationModel.gracePeriod = true;
		StartCoroutine (resetGrace ());
		health -= damageTaken;
		healthValueObject.text = health.ToString ();
		if(health > 66) {
			healthValueObject.color = Color.green;
		}
		if (health < 66) {
			healthValueObject.color = Color.yellow;
		}
		if (health < 33) {
			healthValueObject.color = Color.red;
		}

		if (health < 0) {
			health = 0;
			healthValueObject.text = health.ToString ();
		}
	}
		

	public void RespawnShip() {
		if (lives > 0) {
			GameObject.Instantiate (player, Camera.current.transform);
			lives -= 1;
			RemoveHealth (-100);
		} else {
			GameOver ();
		}
		updatePlayerLifeUI ();
	}

	public void GameOver()  {
		Debug.Log ("Game Over my man");
		ApplicationModel.score = score;
		Debug.Log (ApplicationModel.score);
		GameObject.Find ("MenuHandler").GetComponent<menuHandler> ().GameOver ();
	}

	void updatePlayerLifeUI() {
		foreach (Transform child in healthIconHolder.transform) {
			Destroy (child.gameObject);
		}

		for (int i = 0; i < lives; i++) {
			GameObject icon = GameObject.Instantiate (healthIconPrefab, healthIconHolder.transform);

			RectTransform rt = (RectTransform)icon.transform;
			rt.position = new Vector2 (healthIconHolder.transform.position.x + i*rt.rect.width, healthIconHolder.transform.position.y);
		}
	}

	IEnumerator resetGrace() {
		yield return new WaitForSeconds (1);
		ApplicationModel.gracePeriod = false;
	}
		
		
}
