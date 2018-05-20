using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadController : MonoBehaviour 
{
	// -- Animations --
	public Sprite Default;
	public Sprite HitLeft;
	public Sprite HitRight;
	public Sprite HitMid;

	SpriteRenderer SpritRend; //Looking around n such 

	public float HitTimer;
	public bool isHit = false;
	// Could Use GameController
	// Use this for initialization
	void Start () 
	{
		SpritRend = GetComponent<SpriteRenderer>();
		HitTimer = 0f;
	}
	
	// Update is called once per frame
	void Update () 
	{

		//hit timer forsprite change
		if (isHit == true) 
		{
			
			HitTimer += Time.deltaTime;

			if (HitTimer >= 0.5f) 
			{
				HitTimer = 0f;
				isHit = false;
				SpritRend.sprite = Default;
			}
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Rain") 
		{
			// add to wet 
			//GameManagerScript.RemoveDrop ();
			int i = 0;
			i = Random.Range (0, 4);

			if (i == 0) 
			{
				SpritRend.sprite = HitLeft;
			}
			if (i == 2) 
			{
				SpritRend.sprite = HitMid;
			}
			if (i == 3) 
			{
				SpritRend.sprite = HitRight;
			}
		}
		isHit = true;
	}
}
