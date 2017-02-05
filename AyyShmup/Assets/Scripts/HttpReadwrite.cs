using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[System.Serializable]
public class HighScore
{
	public string name;
	public int score;
}

[System.Serializable]
public class HighScores
{
	public HighScore[] scores;
}

public class HttpReadwrite: MonoBehaviour {
	void Start() {
		StartCoroutine(GetText());
	}

	IEnumerator GetText() {
		using(UnityWebRequest www = UnityWebRequest.Get("https://ayyshmup-highscore-server.herokuapp.com/scores")) {
			yield return www.Send();

			if(www.isError) {
				Debug.Log(www.error);
			}
			else {
				// Show results as text
				//Debug.Log(www.downloadHandler.text);
				HighScores hs = JsonUtility.FromJson<HighScores> (www.downloadHandler.text);
				GameObject.Find ("HighScoreHolder").GetComponent<CreateHighscores> ().createHighscore (hs);
				/*foreach (HighScore h in hs.scores) {
					Debug.Log ("name: " + h.name);
					Debug.Log ("score: " + h.score);
				}*/

				// Or retrieve results as binary data
				byte[] results = www.downloadHandler.data;
			}
		}
	}

	public void PostHighScore()
	{
		Debug.Log ("Post");

		HighScore hs = new HighScore ();
		hs.name = ApplicationModel.name;
		hs.score = ApplicationModel.score;
		ApplicationModel.score = 0;
		StartCoroutine (POST (hs));
	}

	IEnumerator POST(HighScore hs) {
		Dictionary<string, string> headers = new Dictionary<string, string> ();
		headers.Add ("Content-Type", "application/json");
		string jsonData = JsonUtility.ToJson (hs);
		byte[] postData = System.Text.Encoding.UTF8.GetBytes (jsonData);

		WWW www = new WWW ("https://ayyshmup-highscore-server.herokuapp.com/scores",
			postData,
			headers);

		yield return www;
		Debug.Log (www);
	}
}
