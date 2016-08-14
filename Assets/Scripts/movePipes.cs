using UnityEngine;
using System.Collections;

public class movePipes : MonoBehaviour {

	public Vector2 velocity = new Vector2(-5, 0);

	private Rigidbody2D rb;

	private void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = velocity;
	}
}
