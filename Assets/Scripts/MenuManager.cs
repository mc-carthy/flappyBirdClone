using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuManager : MonoBehaviour {

	public void LoadGame () {
		SceneManager.LoadScene ("Main");
	}
}
