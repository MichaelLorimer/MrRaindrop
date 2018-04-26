using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainController : MonoBehaviour 
{
	public float speed;

	Rigidbody2D RainRB;
	// Use this for initialization
	void Start () 
	{
		RainRB = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector2 CurrentPos = RainRB.position;
		CurrentPos.y -= speed * Time.deltaTime;
		RainRB.position = CurrentPos;
	}

	/*void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player" || col.gameObject.tag == "MrRainbow") 
		{
			Destroy (this.gameObject);
		}
	}*/

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "MrRainbow") 
		{
			Destroy (this.gameObject);
		}

	}
}
