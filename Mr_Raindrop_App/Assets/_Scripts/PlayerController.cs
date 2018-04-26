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
		if (Input.GetKey (KeyCode.A)) 
		{
			Vector2 CurrentPos = HatRB.position;
			CurrentPos.x -= speed * Time.deltaTime;
			HatRB.position = CurrentPos;
		}
		if (Input.GetKey (KeyCode.D)) 
		{
			Vector2 CurrentPos = HatRB.position;
			CurrentPos.x += speed * Time.deltaTime;
			HatRB.position = CurrentPos;
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Rain") 
		{
			Debug.Log ("Collisons n shit" + col.name);
			Destroy (col.gameObject);
		}
	}
}
