using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuHandler : MonoBehaviour {

	// Use this for initialization
	public void StartGame () {
		StartCoroutine (levelChange());
	}

	public void MainMenu() {
		StartCoroutine (toMainMenu());
	}

	public void GameOver() {
		StartCoroutine (toGameOver());
	}

	IEnumerator levelChange()
	{
		yield return SceneManager.LoadSceneAsync ("test");
	}

	IEnumerator toMainMenu()
	{
		yield return SceneManager.LoadSceneAsync ("MainMenu");
	}

	IEnumerator toGameOver()
	{
		yield return SceneManager.LoadSceneAsync ("GameOver");
	}
	

}
