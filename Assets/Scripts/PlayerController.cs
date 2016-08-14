using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public Vector2 jumpForce = new Vector2(0, 300);

	private Rigidbody2D rb;

	private void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	private void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			rb.velocity = Vector2.zero;
			rb.AddForce (jumpForce);
		}
	}
}
