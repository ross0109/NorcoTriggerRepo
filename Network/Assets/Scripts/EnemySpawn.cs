using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

	public GameObject[] spawnObject;
	public float radius = 1.0f;
	public float minSpawnTime = 1.0f;
	public float maxSpawnTime = 10.0f;
	public float timeAcceleration = -0.005f;
	public bool constantSpawn = false;
	public Transform spawnPosition;
	Vector3 randomLocation;

	void Start () {
		if(constantSpawn == true){
			SpawnEnemy();
		}
		else{
			Invoke ("SpawnEnemy", Random.Range (minSpawnTime, maxSpawnTime));
		}
	}

	void SpawnEnemy () 
	{
		minSpawnTime = minSpawnTime+timeAcceleration;
		maxSpawnTime = maxSpawnTime+timeAcceleration;
		randomLocation = Random.insideUnitSphere * 20; //5 is radius
		randomLocation.y = 0.0f;
		float spawnRadius = radius;
		int spawnObjectIndex = Random.Range(0, spawnObject.Length);
		Instantiate(spawnObject[spawnObjectIndex], spawnPosition.position + randomLocation, spawnObject[spawnObjectIndex].transform.rotation);
		if (constantSpawn == true)
		{
			Invoke ("SpawnEnemy", Random.Range (minSpawnTime, maxSpawnTime));
		}
	}
}
