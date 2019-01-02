
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour 
{
	public GameObject prefab; //Store the rainprefab
    public GameObject SnowPrefab; // Store Snow Prefab
	public GameObject CoinPrefab; //Store the Coin prefab

	public static int NumDrops; // Number of drops 
	public static int MaxNumDrop = 5;

	public static int score; //Current Score
	public static int wetness;//Current Wetnesslevel 

	public static int CoinScore;
    public static bool coinSpawned;
    public float rng;


    public Text scoreText; // Holds ref to GUIText Compnenet
	public Text wetText; // Holds ref to GUIText Compnenet -- Temp --
	public Text CoinText; // Holds ref to GUIText Compnenet -- Temp --
	public Slider WetnessSlider;

    // Use this for initialization
    void Start ()
	{
        coinSpawned = false;
		CoinScore = 0;
		
		NumDrops = 0; //Set Default valueof0 uponsarting the game 

		score = 0; //Set Default valueof0 uponsarting thegame 
		wetness = 0; //Set Default valueof0 uponsarting thegame 

		WetnessSlider.value = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (NumDrops < MaxNumDrop)
		{
			Vector2 SpawnPos = new Vector2 (Random.Range (-2.9f, 2.79f), 6f); //Chose a spawnpoint in a random range
			Instantiate (prefab, SpawnPos, Quaternion.identity); //Create the prefab oncea position ischosen
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



		scoreText.text = "" + score; // Display score 
		CoinText.text = "" + CoinScore; // Display score 
		wetText.text = "" + wetness; // Display score 
		WetnessSlider.value = wetness;
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
}
