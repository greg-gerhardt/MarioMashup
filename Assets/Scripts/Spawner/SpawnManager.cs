using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {
	public GameObject[] Enemy;
	public float SpawnTimer;

	// Use this for initialization
	void Start () {
		StartCoroutine ("SpawnEnemy");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator SpawnEnemy(){
		yield return new WaitForSeconds (Random.value * SpawnTimer);
		Instantiate (Enemy [0], transform.position, Quaternion.identity);
		StartCoroutine ("RecurseSpawn");
	}

	IEnumerator RecurseSpawn(){
		yield return StartCoroutine ("SpawnEnemy");
	}
}
