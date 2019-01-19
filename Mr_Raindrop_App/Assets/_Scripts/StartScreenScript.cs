using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class StartScreenScript : MonoBehaviour
{

    public Text HighScoreText = null; // Holds ref to GUIText Component
    public int SavedScore = 0;
    public int SavedCoin = 0;

    private void Awake()
    {
       LoadData();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void QuitGame()
    {
        Debug.Log("Game Closed");
        //Confirm quit here --
        Application.Quit();
    }

    public void ReturnToMinMenu()
    {
        SceneManager.LoadScene("StartScreen");
    }

    public void RestartGame()
    {
        SaveData();
        SceneManager.LoadScene("Main");
    }

    public void OpenOptions()
    {
        Debug.Log("OptionsMenu");
    }

    public void VolumeToggle()
    {
        Debug.Log("VolumeOff");
    }

    public void Facebookbutton()
    {
        Debug.Log("Share to facebook");
    }

    public void TwitterButton()
    {
        Debug.Log("ShareToTwitter");
    }

    public void GooglePlayButton()
    {
        Debug.Log("GooglePlayButton");
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



    public void SaveData()
    {
        if (GameManagerScript.score > SaveAndLoad.CurrentScore)
        {
            SaveAndLoad.CurrentScore = GameManagerScript.score;
        }

        SaveAndLoad.CurrentCoin = SaveAndLoad.CurrentCoin + GameManagerScript.CoinScore;
    }

    public void LoadData()
    {
        SaveAndLoad.LoadFile();
        if (SavedScore < SaveAndLoad.CurrentScore)
        {
            SavedScore = SaveAndLoad.CurrentScore;
            HighScoreText.text = "HighScore: " + SavedScore;
        }
        SavedCoin = SaveAndLoad.CurrentCoin;
    }
}
