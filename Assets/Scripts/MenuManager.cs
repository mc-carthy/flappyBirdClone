using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class MenuManager : MonoBehaviour {

	public Text highScoreText;

	private int currentHighScore, highScore;

	private void Start () {
		currentHighScore = PlayerPrefs.GetInt ("currentHighScore", 0);
		highScore = PlayerPrefs.GetInt ("highScore");
		SetHighScore (currentHighScore);
		highScoreText.text = "High Score: " + highScore.ToString ();
	}

	public void LoadGame () {
		SceneManager.LoadScene ("Main");
	}

	private void SetHighScore (int currentHighScore) {
		if (currentHighScore > highScore) {
			currentHighScore = highScore;
		}
	}
}
