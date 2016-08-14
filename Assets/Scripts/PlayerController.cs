using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public Vector2 jumpForce = new Vector2(0, 300);

	private Rigidbody2D rb;
	private bool isControllable = true;
	private ScoreKeeper sk;

	private void Start () {
		rb = GetComponent<Rigidbody2D> ();
		sk = FindObjectOfType<ScoreKeeper> ();
	}

	private void Update () {
		if (isControllable) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				rb.velocity = Vector2.zero;
				rb.AddForce (jumpForce);
			}
		}
		CheckYPos ();
	}

	private void OnCollisionEnter2D (Collision2D col) {
		isControllable = false;
	}

	private void OnTriggerEnter2D (Collider2D col) { 
		if (col.tag == "pipeGap") {
			sk.IncreaseScore ();
		}
	}

	private void CheckYPos () {
		Vector2 screenPos = Camera.main.WorldToScreenPoint (transform.position);

		if (screenPos.y > Screen.height || screenPos.y < 0) {
			OnDie ();
		}
	}

	private void OnDie () {
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
	}
}
