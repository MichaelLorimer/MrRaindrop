﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MMRain : MonoBehaviour 
{
	public float speed;

	Rigidbody2D RainRB;
	Animator    RainAnimator;
	CircleCollider2D CirCol;

	// Use this for initialization
	void Start () 
	{
		RainRB = GetComponent<Rigidbody2D>();
		RainAnimator = GetComponent<Animator>();
		CirCol = GetComponent<CircleCollider2D> ();
	}

	// Update is called once per frame
	void Update () 
	{
		Vector2 CurrentPos = RainRB.position;
		CurrentPos.y -= speed * Time.deltaTime;
		RainRB.position = CurrentPos;
	}

	//Collides with 2 object so
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "MrRaindrop") 
		{
			CirCol.enabled = false;
			MMRainController.RemoveDrop ();
			RainAnimator.SetBool ("Dead", true);
			speed = 0f;
			Destroy (this.gameObject, 0.2f);
		}
	}
}