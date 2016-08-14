using UnityEngine;
using System.Collections;

public class MovePipes : MonoBehaviour {

	public Vector2 velocity = new Vector2(-5, 0);

	private Rigidbody2D rb;

	private void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = velocity;
	}

	private void Update () {
		Vector2 screenPos = Camera.main.WorldToScreenPoint (transform.position);

		if (screenPos.x < -5f) {
			Destroy(this.gameObject);
		}
	}
}
