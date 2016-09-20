using UnityEngine;
using System.Collections;

public class EnemyManagre : MonoBehaviour {
	public float MovementSpeed;
	public Vector2 InverseMagnitude;

	private GameObject Player;
	private Transform PTrans;
	private float RanSpeed;
	private int dir;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Mario");
		PTrans = Player.GetComponent<Transform> ();
		RanSpeed = Random.value + 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (PTrans.position.x < transform.position.x) {
			dir = -1;
		}
		else {
			dir = 1;
		}

		InverseMagnitude = transform.right * MovementSpeed * dir * Time.deltaTime * RanSpeed;
	}

	void OnTriggerStay2D(Collider2D other){
		if (other.gameObject.name == "Mario") {
			transform.position += transform.right * MovementSpeed * dir * Time.deltaTime * RanSpeed;
		}
	}
}
