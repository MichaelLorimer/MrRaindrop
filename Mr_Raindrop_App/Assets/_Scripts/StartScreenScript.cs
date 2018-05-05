using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartScreenScript : MonoBehaviour 
{
	public void PlayGame()
	{
		SceneManager.LoadScene ("Main");
	}

	public void QuitGame()
	{
		Debug.Log ("Game Closed");
		Application.Quit ();
	}

	public void OpenOptions()
	{
		Debug.Log ("OptionsMenu");
	}

}
