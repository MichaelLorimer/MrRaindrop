using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour 
{
	public GameObject prefab; //Store the rainprefab

	public static int NumDrops; // Number of drops 
	public int MaxNumDrop = 5;

	public static int score; //Current Score
	public static int wetness;//Current Wetnesslevel 

	public int drop; //Tem variablefor testing -- Remove later --

	public Text scoreText; // Holds ref to GUIText Compnenet
	public Text wetText; // Holds ref to GUIText Compnenet -- Temp --
	public Slider WetnessSlider;

	// Use this for initialization
	void Start ()
	{

		
		NumDrops = 0; //Set Default valueof0 uponsarting the game 
		drop = 0; //Set Default valueof0 uponsarting thegame 

		score = 0; //Set Default valueof0 uponsarting thegame 
		wetness = 0; //Set Default valueof0 uponsarting thegame 

		WetnessSlider.value = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		if (NumDrops < MaxNumDrop)
		{
			Vector2 SpawnPos = new Vector2 (Random.Range (-3.4f, 3.5f), 6f); //Chose a spawnpoint in a random range
			Instantiate (prefab, SpawnPos, Quaternion.identity); //Create the prefab oncea position ischosen
			NumDrops++;// Incriment theamount of drops that exist
			drop = NumDrops; //temp watch variable 
		}

		scoreText.text = "" + score; // Display score 
		wetText.text = "" + wetness; // Display score 
		WetnessSlider.value = wetness;
	}

	public static void RemoveDrop()
	{
		NumDrops--;
	}


}
