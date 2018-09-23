using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour {

    public GameObject ui;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        if(GameObject.FindObjectOfType<dummyCastle>() == null)
        {
            Debug.Log("Player has won");
            ui.SetActive(true);
        }
	}
}
