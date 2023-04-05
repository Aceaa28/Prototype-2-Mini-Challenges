using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour {
	private float topBound = 30;
	private float lowerBound = -10;
	private float leftBound = -22;
	private float rightBound = 23;
	GameManager gameManager;

	// Start is called before the first frame update
	void Start()
	{
		gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
	}

	// Update is called once per frame
	void Update()
	{
		if (transform.position.z > topBound)
		{
			Destroy(gameObject);
			gameManager.UpdateLives();
		} 
		
		else if (transform.position.z < lowerBound)
		{
			gameManager.UpdateLives();
			Destroy(gameObject);

		}

		if (transform.position.x < )
	}
}
