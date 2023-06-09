﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour 
{
	GameManager gameManager;

	// Start is called before the first frame update
	void Start()
	{
		gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnTriggerEnter(Collider other)
	{
		Destroy(gameObject);
		Destroy(other.gameObject);
		

		if(other.gameObject.CompareTag("Dog")) 
		{
			gameManager.AddScore();
		}
	}
}
