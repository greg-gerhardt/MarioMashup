using UnityEngine;
using System.Collections;

public class EnemyManagre : MonoBehaviour {
	public Transform Player;
	public float MovementSpeed;
	public Vector2 InverseMagnitude;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int dir;

		if (Player.position.x < transform.position.x) {
			dir = -1;
		}
		else {
			dir = 1;
		}

		transform.position += transform.right * MovementSpeed * dir * Time.deltaTime;
		InverseMagnitude = transform.right * MovementSpeed * dir * Time.deltaTime;
	}
}
