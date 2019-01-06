using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissableGO : MonoBehaviour
{
    public GameObject Menu;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DissableGOMenu()
    {
        Menu.SetActive(false);
    }

    public void EnableGOMenu()
    {
        Menu.SetActive(true);
    }
}
