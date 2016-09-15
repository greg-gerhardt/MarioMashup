using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {
	public GameObject[] Enemy;
	public float SpawnTimer;

	public GameObject[] SpawnedEnemies;
	private int i;

	// Use this for initialization
	void Start () {
		StartCoroutine ("SpawnEnemy");
		SpawnedEnemies = new GameObject[5];
	}
	
	// Update is called once per frame
	void Update () {
		CheckForDead ();
	}

	IEnumerator SpawnEnemy(){
		yield return new WaitForSeconds (Random.value * SpawnTimer);
		if (i < SpawnedEnemies.Length - 1) { 
			SpawnedEnemies [i] = Instantiate (Enemy [0], transform.position, Quaternion.identity) as GameObject;
		}
		StartCoroutine ("RecurseSpawn");
	}

	IEnumerator RecurseSpawn(){
		yield return StartCoroutine ("SpawnEnemy");
	}

	void CheckForDead(){
		for (int j = 0; j < SpawnedEnemies.Length; j++) {
			if (SpawnedEnemies [j] == null) {
				i = j; 
				break;
			}
		}
	}
}
