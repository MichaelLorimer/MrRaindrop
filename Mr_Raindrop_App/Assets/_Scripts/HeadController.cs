using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadController : MonoBehaviour 
{
	// -- Animations --
	Animation HurtAnim1;
	Animation HurtAnim2;
	Animation HurtAnim3;

	Animation AmbientAnim; //Looking around n such 

	//Lives 

	// Could Use GameController
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Rain") 
		{
			GameManagerScript.RemoveDrop ();
		}
	}
}
