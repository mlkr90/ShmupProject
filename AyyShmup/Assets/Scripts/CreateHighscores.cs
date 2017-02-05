using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateHighscores : MonoBehaviour {
	public GameObject highscorePrefab;
	public GameObject highScoreHolder;
	private int i = 0;

	public void createHighscore(HighScores hs){
		Debug.Log ("Creating highscores");
		foreach(HighScore h in hs.scores){
			GameObject g = Instantiate (highscorePrefab,new Vector2(highScoreHolder.transform.position.x,highScoreHolder.transform.position.y),Quaternion.identity,highScoreHolder.transform);

			RectTransform rt = (RectTransform)g.transform;
			RectTransform rtH = (RectTransform)highScoreHolder.transform;
			rt.position = new Vector2 (highScoreHolder.transform.position.x - rt.rect.width, highScoreHolder.transform.position.y - i*rt.rect.height/3 + rtH.rect.height/3);
			i++;

			Text[] highscores = g.GetComponentsInChildren<Text> ();
			highscores[0].text = h.name;
			highscores [1].text = h.score.ToString ();

		}
	}
}
