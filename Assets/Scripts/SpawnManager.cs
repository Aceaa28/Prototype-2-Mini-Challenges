using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour 
{

	public GameObject[] animalPrefabs;
	public GameObject[] animalPrefabsLeft;
	public GameObject[] animalPrefabsRight;
	private float spawnX = 20;
	private float spawnZ = 20;
	private float startDelay = 2;
	private float spawnInterval = 2.0f;

	float sideSpawnMinZ = 5;
	float sideSpawnMaxZ = 15;
	float sideSpawnX = 20;

	// Start is called before the first frame update
	void Start()
	{
		InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
		InvokeRepeating("SpawnRandomAnimalLeft", startDelay, spawnInterval);
		InvokeRepeating("SpawnRandomAnimalRight", startDelay, spawnInterval);
	}

	// Update is called once per frame
	void Update()
	{

	}

	void SpawnRandomAnimal()
	{
		int animalIndex = Random.Range(0, animalPrefabs.Length);
		Vector3 spawnPosX = new Vector3(Random.Range(-spawnX, spawnX), 0, spawnZ);
		Instantiate(animalPrefabs[animalIndex], spawnPosX, animalPrefabs[animalIndex].transform.rotation);
	}

	void SpawnRandomAnimalLeft()
	{
		int animalIndex = Random.Range(0, animalPrefabs.Length);
		Vector3 spawnPosX = new Vector3(25, 0, Random.Range(0, 15));
		Instantiate(animalPrefabsLeft[animalIndex], spawnPosX, animalPrefabsLeft[animalIndex].transform.rotation);
	}

	void SpawnRandomAnimalRight()
	{
		int animalIndex = Random.Range(0, animalPrefabs.Length);
		Vector3 spawnPosX = new Vector3(-25, 0, Random.Range(0, 15));
		Instantiate(animalPrefabsRight[animalIndex], spawnPosX, animalPrefabsRight[animalIndex].transform.rotation);
	}
}
