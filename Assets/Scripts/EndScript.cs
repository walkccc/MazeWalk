using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScrirpt : MonoBehaviour {
	public void ChangeToMainScene() {
		SceneManager.LoadScene ("MainScene");
	}

	public void ChangeToMenuScene() {
		SceneManager.LoadScene ("MenuScene");
	}
}
