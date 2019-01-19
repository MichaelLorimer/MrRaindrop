using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	//-- BasicVars --
	public float speed; //Speed var to set in the inpector 

	// -- Components --
	Rigidbody2D HatRB;

	// Use this for initialization
	void Start () 
	{
		HatRB = GetComponent<Rigidbody2D> (); // Get and store the players RigidBody
	}

	// Update is called once per frame
	void Update () 
	{
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            touchPos.y = HatRB.position.y;
            HatRB.position = touchPos;
         
        }
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Coin") 
		{
			//Add to score
			//GameManagerScript.RemoveDrop ();
		}
	}
}
