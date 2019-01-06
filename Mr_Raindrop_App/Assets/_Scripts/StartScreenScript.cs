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
        //Confirm quit here --
		Application.Quit ();
	}

    public void ReturnToMinMenu()
    {
        SceneManager.LoadScene("StartScreen");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void OpenOptions()
	{
		Debug.Log ("OptionsMenu");
	}

	public void VolumeToggle()
	{
		Debug.Log ("VolumeOff");
	}

	public void Facebookbutton()
	{
		Debug.Log ("Share to facebook");
	}

	public void TwitterButton()
	{
		Debug.Log ("ShareToTwitter");
	}

	public void GooglePlayButton()
	{
		Debug.Log ("GooglePlayButton");
	}

    public void InformationPlayButton()
    {
        Debug.Log("GooglePlayButton");
    }

    public void PatreonPlayButton()
    {
        Debug.Log("GooglePlayButton");
    }

    public void KoFiButton()
    {
        Debug.Log("GooglePlayButton");
    }

    public void GooglePlayRateButton()
    {
        Debug.Log("GooglePlayButton");
    }
}
