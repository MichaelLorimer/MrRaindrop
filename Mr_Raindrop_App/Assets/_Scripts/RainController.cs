using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainController : MonoBehaviour 
{
	public float speed;

	Rigidbody2D RainRB;
	Animator    RainAnimator;

	Animation anim;

	bool alive;

	// Use this for initialization
	void Start () 
	{
		RainRB = GetComponent<Rigidbody2D>();
		RainAnimator = GetComponent<Animator>();
		alive = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector2 CurrentPos = RainRB.position;
		CurrentPos.y -= speed * Time.deltaTime;
		RainRB.position = CurrentPos;
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player") 
		{
			RainAnimator.SetBool ("Dead", true);
			Destroy (this.gameObject, 0.13f);
		}
		if (col.gameObject.tag == "MrRaindrop") 
		{
			RainAnimator.SetBool ("Dead", true);
			Destroy (this.gameObject, 0.13f);
		}
	}
}
