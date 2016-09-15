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
		i = 0;
	}
	
	// Update is called once per frame
	void Update () {
		CheckArray ();
	}

	IEnumerator SpawnEnemy(){
		yield return new WaitForSeconds (Random.value * SpawnTimer);
		if (SpawnedEnemies.Length < 5) {
			SpawnedEnemies  += Instantiate (Enemy [0], transform.position, Quaternion.identity) as GameObject;
		}
		StartCoroutine ("RecurseSpawn");
	}

	IEnumerator RecurseSpawn(){
		yield return StartCoroutine ("SpawnEnemy");
	}

	void CheckArray (){
		int k = 0;
		foreach (GameObject Spawned in SpawnedEnemies){
			k++;
		}
		if (k < SpawnedEnemies.Length) {
			i = k;
		}
	}
}
