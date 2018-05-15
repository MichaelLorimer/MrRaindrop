using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeButtonImage : MonoBehaviour
{
	SpriteRenderer spriteRend;
	// Use this for initialization
	void Start () 
	{
		spriteRend = gameObject.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	public void change(Sprite OtherSprite)
	{
		spriteRend.sprite = OtherSprite;
	}
}
