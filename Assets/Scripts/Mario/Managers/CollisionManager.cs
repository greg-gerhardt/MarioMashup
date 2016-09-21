using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CollisionManager : PlayerState {
	public BarretaManager Gun;
	public MonoBehaviour[] DisableScripts;

	private Transform Destination;
	private Animator PlayerAnim;
	private bool EndComplete;
	private GameObject Spawner;
	private SpawnManager Spawned;

	void Start(){
		PlayerAnim = GetComponent<Animator> ();
		bool EndComplete = false;

		Spawner = GameObject.Find ("pipe");
		Spawned = Spawner.GetComponent<SpawnManager> ();
	}

	void Update(){
	}

	void OnCollisionEnter2D (Collision2D coll){
		if (coll.gameObject.tag == "Ground") {
			Standing = true;
		}
		if (coll.gameObject.name == "Zombie(Clone)") {
			if (health != 0) {
				health -= 1;
				SoundSource.clip = FindAudioClip ("MarioPain");
				SoundSource.Play ();
				if (coll.gameObject.transform.position.x > transform.position.x) {
					physics.AddForce (new Vector2 (BlowBack.x * -1, BlowBack.y), ForceMode2D.Impulse);
				}
				else {
					physics.AddForce (BlowBack, ForceMode2D.Impulse);
				}
			}
			if (health == 0) {
				Destroy (coll.gameObject);
				StartCoroutine ("GameOver");
			}

		}
	}

	void OnCollisionExit2D (Collision2D coll){
		if (coll.gameObject.tag == "Ground"){
			Standing = false;
		}
		if (coll.gameObject.name == "Zombie(Clone)") {
			SoundSource.clip = FindAudioClip ("MarioFootsteps");
		}
	}	

	void OnTriggerEnter2D (Collider2D other){
		if (other.gameObject.name == "Barreta") {
			Gun.isActive = true;
		}
		if (other.gameObject.name == "castle") {
			DisableTheScripts ();
			Destination = other.gameObject.transform.GetChild (1);
			EndComplete = true;
			for (int i = 0; i < Spawned.SpawnedEnemies.Length; i++) {
				if (Spawned.SpawnedEnemies [i] != null) {
					Destroy (Spawned.SpawnedEnemies [i]);
				}
			} 
		}
	}

	void OnTriggerStay2D(Collider2D other){
		if (other.gameObject.name == "castle") {
			if (EndComplete) {
				StartCoroutine ("WaitAtCastle");
			}
			if (!EndComplete) {
				transform.position = Vector2.MoveTowards (transform.position, Destination.position, 20f * Time.deltaTime); 
			}
		}
	}

	void OnTriggerExit2D (Collider2D other){
		if (other.gameObject.name == "Barreta") {
			Gun.isActive = false;
		}
	}

	public IEnumerator GameOver(){
		SoundSource.clip = FindAudioClip ("GameOverMusic");
		SoundSource.Play ();
		yield return new WaitForSeconds (SoundSource.clip.length);
		SceneManager.LoadScene ("MainMenu");
	}

	IEnumerator WaitAtCastle(){
		PlayerAnim.SetInteger ("AnimState", 0);
		yield return new WaitForSeconds (1f);
		PlayerAnim.SetInteger ("AnimState", 1);
		EndComplete = false;
	}

	void DisableTheScripts(){
		for (int i = 0; i < DisableScripts.Length; i++) {
			DisableScripts [i].enabled = false;
		}
	}
}
