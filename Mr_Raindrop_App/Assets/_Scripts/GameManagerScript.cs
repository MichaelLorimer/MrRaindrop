using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour 
{
	public GameObject prefab;

	public static int NumDrops; // Number of drops 
	int MaxNumDrop = 5;

	public int drop;
	// Use this for initialization
	void Start ()
	{
		NumDrops = 0;
		drop = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		if (NumDrops < MaxNumDrop)
		{
			Vector2 SpawnPos = new Vector2 (Random.Range (-3.4f, 3.5f), 6f);
			Instantiate (prefab, SpawnPos, Quaternion.identity);
			NumDrops++;
		}
		drop = NumDrops;
	}

	public static void RemoveDrop()
	{
		NumDrops--;
	}
}
