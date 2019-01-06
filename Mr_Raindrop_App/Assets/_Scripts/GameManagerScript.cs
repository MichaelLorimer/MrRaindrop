
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public GameObject prefab; //Store the rainprefab
    public GameObject SnowPrefab; // Store Snow Prefab
    public GameObject CoinPrefab; //Store the Coin prefab
    public GameObject GameOverMenu;
    public GameObject PlayerUI;

    public static int NumDrops; // Number of drops 
    public static int MaxNumDrop = 5;

    public static int score; //Current Score

    public static int CoinScore;
    public static bool coinSpawned;
    public float rng;

    bool IsGameOver;

    public int StartHealth;
    public static int CurrentHealth;

    public Text scoreText; // Holds ref to GUIText Compnenet
    public Text GOscoreText; // Holds ref to GUIText Compnenet

    public Text CoinText; // Holds ref to GUIText Compnenet -- Temp --
    public Slider HealthSlider;

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1f;
        IsGameOver = false;
        coinSpawned = false;
        CoinScore = 0;

        CurrentHealth = StartHealth;

        NumDrops = 0; //Set Default valueof0 uponsarting the game 

        score = 0; //Set Default valueof0 uponsarting thegame 
    }

    // Update is called once per frame
    void Update()
    {
        if (NumDrops < MaxNumDrop)
        {
            Vector2 SpawnPos = new Vector2(Random.Range(-2.9f, 2.79f), 6f); //Chose a spawnpoint in a random range
            Instantiate(prefab, SpawnPos, Quaternion.identity); //Create the prefab oncea position ischosen
                                                                //Check if golden drop 1/100

            NumDrops++;// Incriment theamount of drops that exist
        }

        if (coinSpawned == false)
        {
            float CoinChance = 0.001f;
            rng = (Random.Range(0.0f, 1.0f));
            if (rng <= CoinChance)
            {
                Vector2 SpawnPos = new Vector2(Random.Range(-2.9f, 2.79f), 6f); //Chose a spawnpoint in a random range
                Instantiate(CoinPrefab, SpawnPos, Quaternion.identity); //Create the prefab oncea position ischosen
                coinSpawned = true;
            }
        }

        if (CurrentHealth <= 0f)
        {
            GameOver();
        }


        scoreText.text = "" + score; // Display score 
        GOscoreText.text = "" + score; // Display score 
        CoinText.text = "" + CoinScore; // Display score 

        HealthSlider.value = CurrentHealth;
        HealthSlider.maxValue = StartHealth;

    }

    public static void RemoveDrop()
    {
        NumDrops--;
    }

    public static void RemoveCoin()
    {
        coinSpawned = false;
    }

    void AddGold()
    {
        CoinScore++;
    }

    void GameOver()
    {
        Debug.Log("GameOver");
        GameOverMenu.SetActive(true);
        PlayerUI.SetActive(false);
        PauseGame();
    }

    void PauseGame()
    {
        Time.timeScale = 0f;
    }   
}
