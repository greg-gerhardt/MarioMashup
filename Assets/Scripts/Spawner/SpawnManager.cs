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
<<<<<<< HEAD
		i = 0;
=======
		SpawnedEnemies = new GameObject[5];
>>>>>>> 62d18537ae35569a8923b7a3ce6872fa97e6bf0e
	}
	
	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
		CheckArray ();
=======
		CheckForDead ();
>>>>>>> 62d18537ae35569a8923b7a3ce6872fa97e6bf0e
	}

	IEnumerator SpawnEnemy(){
		yield return new WaitForSeconds (Random.value * SpawnTimer);
<<<<<<< HEAD
		if (SpawnedEnemies.Length < 5) {
			SpawnedEnemies  += Instantiate (Enemy [0], transform.position, Quaternion.identity) as GameObject;
=======
		if (i < SpawnedEnemies.Length - 1) { 
			SpawnedEnemies [i] = Instantiate (Enemy [0], transform.position, Quaternion.identity) as GameObject;
>>>>>>> 62d18537ae35569a8923b7a3ce6872fa97e6bf0e
		}
		StartCoroutine ("RecurseSpawn");
	}

	IEnumerator RecurseSpawn(){
		yield return StartCoroutine ("SpawnEnemy");
	}

<<<<<<< HEAD
	void CheckArray (){
		int k = 0;
		foreach (GameObject Spawned in SpawnedEnemies){
			k++;
		}
		if (k < SpawnedEnemies.Length) {
			i = k;
=======
	void CheckForDead(){
		for (int j = 0; j < SpawnedEnemies.Length; j++) {
			if (SpawnedEnemies [j] == null) {
				i = j; 
				break;
			}
>>>>>>> 62d18537ae35569a8923b7a3ce6872fa97e6bf0e
		}
	}
}
