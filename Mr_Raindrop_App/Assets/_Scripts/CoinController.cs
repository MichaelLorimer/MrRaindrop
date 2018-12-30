using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour 
{
	public float speed;

	Rigidbody2D CoinRB;
	Animator    CoinAnimator;
	BoxCollider2D BoxCol;

	// Use this for initialization
	void Start () 
	{
		CoinRB = GetComponent<Rigidbody2D>();
		CoinAnimator = GetComponent<Animator>();
		BoxCol = GetComponent<BoxCollider2D> ();
	}

	// Update is called once per frame
	void Update () 
	{
		Vector2 CurrentPos = CoinRB.position;
		CurrentPos.y -= speed * Time.deltaTime;
		CoinRB.position = CurrentPos;
	}

	//Collides with 2 object so
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Player" || col.gameObject.tag == "MrRaindrop") 
		{
			BoxCol.enabled = false;
			CoinAnimator.SetBool ("Dead", true);
			speed = 0f;
			GameManagerScript.RemoveCoin ();
			Destroy (this.gameObject, 0.2f);
		}

		if (col.gameObject.tag == "Player") 
		{
			GameManagerScript.CoinScore++;
		}
	}
}
