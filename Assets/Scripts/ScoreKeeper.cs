using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	public Text scoreText;

	public int score = 0;

	private void Start () {
		UpdateScore ();
	}

	public void IncreaseScore() {
		score++;
		UpdateScore ();
	}

	private void UpdateScore() {
		scoreText.text = "Score: " + score.ToString ();
	}

}
