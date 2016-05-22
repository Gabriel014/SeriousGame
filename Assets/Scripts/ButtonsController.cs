using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour {

	public void BackToMenu()
	{
		SceneManager.LoadScene("Menu");
	}

	public void Credits()
	{
		SceneManager.LoadScene("Credits");
	}

	public void Info()
	{
		SceneManager.LoadScene("Info");
	}

	public void Play()
	{
		SceneManager.LoadScene("Game");
	}
}
