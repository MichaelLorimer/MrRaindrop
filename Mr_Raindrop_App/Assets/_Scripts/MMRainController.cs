using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MMRainController : MonoBehaviour 
{
	public GameObject prefab;
	public static int numDrops;
	public static int maxNumDrops;
	public static int goldDrops;

	public int drop;
	void Start ()
	{
		numDrops = 0;
		maxNumDrops = 5;
        Time.timeScale = 1f;
	}

	void Update()
	{
		//SpawnDrops
		if (numDrops < maxNumDrops)
		{
			Vector2 SpawnPos = new Vector2 (Random.Range (-2.8f, 2.8f), 6f); //Chose a spawnpoint in a random range
			Instantiate (prefab, SpawnPos, Quaternion.identity); //Create the prefab oncea position ischosen
			//Check if golden drop 1/100
			drop = numDrops;
			numDrops++;// Incriment theamount of drops that exist
		}
	}

	public static void RemoveDrop()
	{
		numDrops--;
	}
}
