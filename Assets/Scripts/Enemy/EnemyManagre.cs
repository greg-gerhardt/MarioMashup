using UnityEngine;
using System.Collections;

public class EnemyManagre : MonoBehaviour {
	public float MovementSpeed;
	public Vector2 InverseMagnitude;

	private GameObject Player;
	private Transform PTrans;
	private float RanSpeed;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Mario");
		PTrans = Player.GetComponent<Transform> ();
		RanSpeed = Random.value + 1;
	}
	
	// Update is called once per frame
	void Update () {
		int dir;

		if (PTrans.position.x < transform.position.x) {
			dir = -1;
		}
		else {
			dir = 1;
		}

		transform.position += transform.right * MovementSpeed * dir * Time.deltaTime * RanSpeed;
		InverseMagnitude = transform.right * MovementSpeed * dir * Time.deltaTime * RanSpeed;
	}
}
