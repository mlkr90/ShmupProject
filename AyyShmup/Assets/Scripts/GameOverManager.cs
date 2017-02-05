using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour {

	public Text scoreValueObject;
	public Text nameValueObject;
	public Button submitButt;
	public Button mainMenuButt;

	void Start() {
		Debug.Log (ApplicationModel.score);
		scoreValueObject.text = ApplicationModel.score.ToString ();
	}

	public void PlayerNameSubmit() {
		ApplicationModel.name = nameValueObject.text;
		GameObject.Find ("HTTP").GetComponent<HttpReadwrite> ().PostHighScore ();
		submitButt.interactable = false;
		mainMenuButt.interactable = true;
	}

	public void backToMainMenu() {
		GameObject.Find ("MenuHandler").GetComponent<menuHandler> ().MainMenu ();
	}

	public void checkNameField()
	{
		if(nameValueObject.text != null)
		{
			submitButt.interactable = true;
		}
	}
}
