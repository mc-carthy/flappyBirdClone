using UnityEngine;
using System.Collections;

public class pipeGenerator : MonoBehaviour {

	public GameObject pipePair;
	public float minY, maxY;

	private void Start () {
		InvokeRepeating ("CreatePipes", 1f, 3.5f);
	}

	private void CreatePipes () {
		Instantiate (pipePair, new Vector3(transform.position.x, Random.Range(minY, maxY), 0f), Quaternion.identity);
	}
}
